Imports WordOps.MSWord

Public Class Form1



   



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        PopulateListBoxWithOpenWordDocs(lbxOpenWordDocs)
        txtCurrentWordDoc.Text = GetWordCurrentDocName()

        PopulateCustomPropsListView()
        PopulateStdPropsListView()


    End Sub

    Private Sub btnRefreshOpenDocs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshOpenDocs.Click

        PopulateListBoxWithOpenWordDocs(lbxOpenWordDocs)
        txtCurrentWordDoc.Text = GetWordCurrentDocName()
    End Sub

    Private Sub btnSetActiveDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetActiveDoc.Click

        If lbxOpenWordDocs.SelectedItems.Count <> 1 Then Exit Sub

        MakeWordDocActive(lbxOpenWordDocs.SelectedItems(0))

        txtCurrentWordDoc.Text = GetWordCurrentDocName()

        PopulateCustomPropsListView()
        PopulateStdPropsListView()




    End Sub

    Private Sub btnUpdateHeaderFooter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        btnStop.Visible = True
        progOverallProgress.Visible = True
        progUpdateProgress.Visible = True
        UpdateFieldsInWordHeaderFooter(progUpdateProgress, progOverallProgress)
        progOverallProgress.Visible = False
        progUpdateProgress.Visible = False
        btnStop.Visible = False
        MsgBox("Done", MsgBoxStyle.Information, "Field Updates")

    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click

        blnWordOpsInterrupt = True
        btnStop.Visible = False
        lblTask.Text = ""
        UncheckAllFieldCheckBoxes()

    End Sub

    Private Sub btnUpdateTOC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        UpdateTOCinWordDoc()
        MsgBox("Done", MsgBoxStyle.Information, "Field Updates")

    End Sub

    Private Sub btnUpdateListOfFigures_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        UpdateTableOfFiguresInWordDoc()
        MsgBox("Done", MsgBoxStyle.Information, "Field Updates")

    End Sub

    Private Sub btnUpdateMainBodyFields_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        progMarquee.Visible = True
        UpdateWholeStoryMSWord()
        progMarquee.Visible = False

        'progOverallProgress.Visible = True
        'progOverallProgress.Value = 0
        'btnStop.Visible = True

        'UpdateMainFieldsInWordDoc(progOverallProgress)

        'btnStop.Visible = False

        MsgBox("Done")

    End Sub

 
    Private Sub btnRefreshCustomDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshCustomDoc.Click
        PopulateCustomPropsListView()
    End Sub

    Private Sub PopulateCustomPropsListView()

        lvwCustomPropsList.Items.Clear()

        FillListViewFromDataTable(lvwCustomPropsList, GetListOfCustomWordProperties)
        grpCustomProperties.Text = "Custom Properties for " & GetWordCurrentDocName()

    End Sub

    Private Sub PopulateStdPropsListView()

        lvwWordStdProperties.Items.Clear()
        grpStandardProperties.Text = "Std Properties for " & GetWordCurrentDocName()
        FillListViewFromDataTable(lvwWordStdProperties, GetListOfStdWordProperties)

    End Sub


    Private Sub btnRefreshStdWordPropsList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshStdWordPropsList.Click
        PopulateStdPropsListView()
    End Sub

    Private Sub btnModifyWordCustomApp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifyWordCustomApp.Click


        Dim NewValue As String
        Dim SelectedProperty As ListViewItem

        If lvwCustomPropsList.SelectedItems.Count = 1 Then
            SelectedProperty = lvwCustomPropsList.SelectedItems.Item(0)
            NewValue = InputBox("Enter new value for: " & SelectedProperty.Text, "ENTER NEW VALUE", lvwCustomPropsList.SelectedItems(0).SubItems(1).Text)

            If NewValue <> vbNullString Then

                ModifyWordCustomProperty(lvwCustomPropsList.SelectedItems(0).SubItems(0).Text, NewValue)
                PopulateCustomPropsListView()
            End If

        End If

    End Sub

    Private Sub btnModifyStdPropValue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifyStdPropValue.Click
        Dim NewValue As String
        Dim SelectedProperty As ListViewItem

        If lvwWordStdProperties.SelectedItems.Count = 1 Then

            SelectedProperty = lvwWordStdProperties.SelectedItems.Item(0)
            NewValue = InputBox("Enter new value for: " & SelectedProperty.Text, "ENTER NEW VALUE", lvwWordStdProperties.SelectedItems(0).SubItems(1).Text)

            If NewValue <> vbNullString Then

                ModifyWordStdProperty(lvwWordStdProperties.SelectedItems(0).SubItems(0).Text, NewValue)
                PopulateStdPropsListView()
            End If

        End If

    End Sub

    
    Private Sub btnStartUpdates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartUpdates.Click

        btnStop.Visible = True

        If chkMainBody.Checked Then
            lblTask.Text = "Updating Main Body Fields..."
            chkMainBody.Checked = False
            Application.DoEvents()
            If blnWordOpsInterrupt Then Exit Sub
            progMarquee.Visible = True
            UpdateWholeStoryMSWord()
            progMarquee.Visible = False

        End If

        If chkTOC.Checked Then
            lblTask.Text = "Updating TOC Fields..."
            chkTOC.Checked = False
            Application.DoEvents()
            If blnWordOpsInterrupt Then Exit Sub
            UpdateTOCinWordDoc()

        End If

        If chkListOfFigures.Checked Then
            lblTask.Text = "Updating Table of Figures Fields..."
            chkListOfFigures.Checked = False
            Application.DoEvents()
            If blnWordOpsInterrupt Then Exit Sub
            UpdateTableOfFiguresInWordDoc()

        End If

        If chkHeadersFooters.Checked Then
            lblTask.Text = "Updating Header/Footer Fields..."
            chkHeadersFooters.Checked = False
            Application.DoEvents()
            If blnWordOpsInterrupt Then Exit Sub
            btnStop.Visible = True
            progOverallProgress.Visible = True
            progUpdateProgress.Visible = True
            UpdateFieldsInWordHeaderFooter(progUpdateProgress, progOverallProgress)
            progOverallProgress.Visible = False
            progUpdateProgress.Visible = False

        End If

        chkCheckAll.Checked = False
        btnStop.Visible = False
        lblTask.Text = "Done"


    End Sub

    Private Sub chkCheckAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCheckAll.CheckedChanged
        If chkCheckAll.Checked Then
            chkHeadersFooters.Checked = True
            chkListOfFigures.Checked = True
            chkMainBody.Checked = True
            chkTOC.Checked = True
        Else
            chkHeadersFooters.Checked = False
            chkListOfFigures.Checked = False
            chkMainBody.Checked = False
            chkTOC.Checked = False
        End If
    End Sub

    Private Sub UncheckAllFieldCheckBoxes()
        chkHeadersFooters.Checked = False
        chkListOfFigures.Checked = False
        chkMainBody.Checked = False
        chkTOC.Checked = False
        chkCheckAll.Checked = False
    End Sub
End Class
