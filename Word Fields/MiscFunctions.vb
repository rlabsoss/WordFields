Module MiscFunctions

#Region "List View Ops"
    Public Sub FillListViewFromDataTable(ByVal MyListView As ListView, ByVal DT As DataTable)

        '---------------------------------------------------------
        '   Given a List View Object and a data table,
        '       fill the List View with records
        '---------------------------------------------------------

        Dim DR As DataTableReader = DT.CreateDataReader
        Dim LV As ListView = MyListView
        Dim Row As Integer = 0

        While DR.Read

            Dim LVI As ListViewItem = LV.Items.Add(DR.Item(0).ToString)


            For i = 1 To DR.FieldCount - 1
                LVI.SubItems.Add(DR.Item(i).ToString)
                LV.Items(Row).BackColor = Color.White
            Next

            Row += 1

        End While

        '----- Resize the Columns ---
        For i As Integer = 0 To MyListView.Columns.Count - 1
            MyListView.Columns(i).Width = -2
        Next i
        '---

        '---Cleanup---

    End Sub

#End Region

End Module
