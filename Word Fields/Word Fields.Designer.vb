<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lbxOpenWordDocs = New System.Windows.Forms.ListBox()
        Me.btnRefreshOpenDocs = New System.Windows.Forms.Button()
        Me.txtCurrentWordDoc = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSetActiveDoc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.progUpdateProgress = New System.Windows.Forms.ProgressBar()
        Me.progOverallProgress = New System.Windows.Forms.ProgressBar()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.progMarquee = New System.Windows.Forms.ProgressBar()
        Me.tabsMain = New System.Windows.Forms.TabControl()
        Me.tabDocs = New System.Windows.Forms.TabPage()
        Me.tabProperties = New System.Windows.Forms.TabPage()
        Me.grpStandardProperties = New System.Windows.Forms.GroupBox()
        Me.btnRefreshStdWordPropsList = New System.Windows.Forms.Button()
        Me.btnModifyStdPropValue = New System.Windows.Forms.Button()
        Me.lvwWordStdProperties = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grpCustomProperties = New System.Windows.Forms.GroupBox()
        Me.btnRefreshCustomDoc = New System.Windows.Forms.Button()
        Me.lvwCustomPropsList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnRemoveWordCustomProperty = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnModifyWordCustPropName = New System.Windows.Forms.Button()
        Me.btnAddNewWordCustProp = New System.Windows.Forms.Button()
        Me.btnModifyWordCustomApp = New System.Windows.Forms.Button()
        Me.tabFields = New System.Windows.Forms.TabPage()
        Me.grpUpdateChoices = New System.Windows.Forms.GroupBox()
        Me.chkMainBody = New System.Windows.Forms.CheckBox()
        Me.chkTOC = New System.Windows.Forms.CheckBox()
        Me.chkListOfFigures = New System.Windows.Forms.CheckBox()
        Me.chkHeadersFooters = New System.Windows.Forms.CheckBox()
        Me.btnStartUpdates = New System.Windows.Forms.Button()
        Me.lblTask = New System.Windows.Forms.Label()
        Me.chkCheckAll = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.tabsMain.SuspendLayout()
        Me.tabDocs.SuspendLayout()
        Me.tabProperties.SuspendLayout()
        Me.grpStandardProperties.SuspendLayout()
        Me.grpCustomProperties.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.tabFields.SuspendLayout()
        Me.grpUpdateChoices.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbxOpenWordDocs
        '
        Me.lbxOpenWordDocs.FormattingEnabled = True
        Me.lbxOpenWordDocs.Location = New System.Drawing.Point(55, 21)
        Me.lbxOpenWordDocs.Name = "lbxOpenWordDocs"
        Me.lbxOpenWordDocs.Size = New System.Drawing.Size(243, 147)
        Me.lbxOpenWordDocs.TabIndex = 0
        '
        'btnRefreshOpenDocs
        '
        Me.btnRefreshOpenDocs.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRefreshOpenDocs.Image = CType(resources.GetObject("btnRefreshOpenDocs.Image"), System.Drawing.Image)
        Me.btnRefreshOpenDocs.Location = New System.Drawing.Point(6, 19)
        Me.btnRefreshOpenDocs.Name = "btnRefreshOpenDocs"
        Me.btnRefreshOpenDocs.Size = New System.Drawing.Size(43, 43)
        Me.btnRefreshOpenDocs.TabIndex = 1
        Me.btnRefreshOpenDocs.UseVisualStyleBackColor = False
        '
        'txtCurrentWordDoc
        '
        Me.txtCurrentWordDoc.Location = New System.Drawing.Point(12, 29)
        Me.txtCurrentWordDoc.Name = "txtCurrentWordDoc"
        Me.txtCurrentWordDoc.Size = New System.Drawing.Size(276, 20)
        Me.txtCurrentWordDoc.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbxOpenWordDocs)
        Me.GroupBox1.Controls.Add(Me.btnRefreshOpenDocs)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 183)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Docs in Session"
        '
        'btnSetActiveDoc
        '
        Me.btnSetActiveDoc.Location = New System.Drawing.Point(112, 55)
        Me.btnSetActiveDoc.Name = "btnSetActiveDoc"
        Me.btnSetActiveDoc.Size = New System.Drawing.Size(75, 23)
        Me.btnSetActiveDoc.TabIndex = 5
        Me.btnSetActiveDoc.Text = "^"
        Me.btnSetActiveDoc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Active Doc"
        '
        'progUpdateProgress
        '
        Me.progUpdateProgress.Location = New System.Drawing.Point(191, 34)
        Me.progUpdateProgress.Name = "progUpdateProgress"
        Me.progUpdateProgress.Size = New System.Drawing.Size(273, 23)
        Me.progUpdateProgress.TabIndex = 8
        Me.progUpdateProgress.Visible = False
        '
        'progOverallProgress
        '
        Me.progOverallProgress.Location = New System.Drawing.Point(191, 64)
        Me.progOverallProgress.Name = "progOverallProgress"
        Me.progOverallProgress.Size = New System.Drawing.Size(273, 23)
        Me.progOverallProgress.TabIndex = 9
        Me.progOverallProgress.Visible = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.DarkRed
        Me.btnStop.Location = New System.Drawing.Point(50, 222)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 10
        Me.btnStop.Text = "HALT"
        Me.btnStop.UseVisualStyleBackColor = False
        Me.btnStop.Visible = False
        '
        'progMarquee
        '
        Me.progMarquee.Location = New System.Drawing.Point(191, 94)
        Me.progMarquee.Name = "progMarquee"
        Me.progMarquee.Size = New System.Drawing.Size(100, 23)
        Me.progMarquee.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.progMarquee.TabIndex = 15
        Me.progMarquee.Visible = False
        '
        'tabsMain
        '
        Me.tabsMain.Controls.Add(Me.tabDocs)
        Me.tabsMain.Controls.Add(Me.tabProperties)
        Me.tabsMain.Controls.Add(Me.tabFields)
        Me.tabsMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabsMain.Location = New System.Drawing.Point(0, 0)
        Me.tabsMain.Name = "tabsMain"
        Me.tabsMain.SelectedIndex = 0
        Me.tabsMain.Size = New System.Drawing.Size(628, 486)
        Me.tabsMain.TabIndex = 16
        '
        'tabDocs
        '
        Me.tabDocs.Controls.Add(Me.GroupBox1)
        Me.tabDocs.Controls.Add(Me.txtCurrentWordDoc)
        Me.tabDocs.Controls.Add(Me.Label1)
        Me.tabDocs.Controls.Add(Me.btnSetActiveDoc)
        Me.tabDocs.Location = New System.Drawing.Point(4, 22)
        Me.tabDocs.Name = "tabDocs"
        Me.tabDocs.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDocs.Size = New System.Drawing.Size(620, 460)
        Me.tabDocs.TabIndex = 0
        Me.tabDocs.Text = "Docs"
        Me.tabDocs.UseVisualStyleBackColor = True
        '
        'tabProperties
        '
        Me.tabProperties.Controls.Add(Me.grpStandardProperties)
        Me.tabProperties.Controls.Add(Me.grpCustomProperties)
        Me.tabProperties.Location = New System.Drawing.Point(4, 22)
        Me.tabProperties.Name = "tabProperties"
        Me.tabProperties.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProperties.Size = New System.Drawing.Size(620, 460)
        Me.tabProperties.TabIndex = 1
        Me.tabProperties.Text = "Properties"
        Me.tabProperties.UseVisualStyleBackColor = True
        '
        'grpStandardProperties
        '
        Me.grpStandardProperties.Controls.Add(Me.btnRefreshStdWordPropsList)
        Me.grpStandardProperties.Controls.Add(Me.btnModifyStdPropValue)
        Me.grpStandardProperties.Controls.Add(Me.lvwWordStdProperties)
        Me.grpStandardProperties.Location = New System.Drawing.Point(8, 231)
        Me.grpStandardProperties.Name = "grpStandardProperties"
        Me.grpStandardProperties.Size = New System.Drawing.Size(598, 217)
        Me.grpStandardProperties.TabIndex = 18
        Me.grpStandardProperties.TabStop = False
        Me.grpStandardProperties.Text = "Standard Properties"
        '
        'btnRefreshStdWordPropsList
        '
        Me.btnRefreshStdWordPropsList.Image = CType(resources.GetObject("btnRefreshStdWordPropsList.Image"), System.Drawing.Image)
        Me.btnRefreshStdWordPropsList.Location = New System.Drawing.Point(546, 19)
        Me.btnRefreshStdWordPropsList.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnRefreshStdWordPropsList.Name = "btnRefreshStdWordPropsList"
        Me.btnRefreshStdWordPropsList.Size = New System.Drawing.Size(42, 42)
        Me.btnRefreshStdWordPropsList.TabIndex = 4
        Me.btnRefreshStdWordPropsList.UseVisualStyleBackColor = True
        '
        'btnModifyStdPropValue
        '
        Me.btnModifyStdPropValue.Location = New System.Drawing.Point(377, 19)
        Me.btnModifyStdPropValue.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnModifyStdPropValue.Name = "btnModifyStdPropValue"
        Me.btnModifyStdPropValue.Size = New System.Drawing.Size(164, 23)
        Me.btnModifyStdPropValue.TabIndex = 3
        Me.btnModifyStdPropValue.Text = "Modify Value of Selected"
        Me.btnModifyStdPropValue.UseVisualStyleBackColor = True
        '
        'lvwWordStdProperties
        '
        Me.lvwWordStdProperties.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvwWordStdProperties.FullRowSelect = True
        Me.lvwWordStdProperties.GridLines = True
        Me.lvwWordStdProperties.Location = New System.Drawing.Point(5, 19)
        Me.lvwWordStdProperties.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.lvwWordStdProperties.Name = "lvwWordStdProperties"
        Me.lvwWordStdProperties.Size = New System.Drawing.Size(348, 192)
        Me.lvwWordStdProperties.TabIndex = 1
        Me.lvwWordStdProperties.UseCompatibleStateImageBehavior = False
        Me.lvwWordStdProperties.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Property Name"
        Me.ColumnHeader3.Width = 93
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Current Value"
        Me.ColumnHeader4.Width = 212
        '
        'grpCustomProperties
        '
        Me.grpCustomProperties.Controls.Add(Me.btnRefreshCustomDoc)
        Me.grpCustomProperties.Controls.Add(Me.lvwCustomPropsList)
        Me.grpCustomProperties.Controls.Add(Me.GroupBox4)
        Me.grpCustomProperties.Controls.Add(Me.GroupBox3)
        Me.grpCustomProperties.Location = New System.Drawing.Point(6, 14)
        Me.grpCustomProperties.Name = "grpCustomProperties"
        Me.grpCustomProperties.Size = New System.Drawing.Size(600, 211)
        Me.grpCustomProperties.TabIndex = 17
        Me.grpCustomProperties.TabStop = False
        Me.grpCustomProperties.Text = "Custom Properties"
        '
        'btnRefreshCustomDoc
        '
        Me.btnRefreshCustomDoc.Image = CType(resources.GetObject("btnRefreshCustomDoc.Image"), System.Drawing.Image)
        Me.btnRefreshCustomDoc.Location = New System.Drawing.Point(548, 38)
        Me.btnRefreshCustomDoc.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnRefreshCustomDoc.Name = "btnRefreshCustomDoc"
        Me.btnRefreshCustomDoc.Size = New System.Drawing.Size(38, 42)
        Me.btnRefreshCustomDoc.TabIndex = 20
        Me.btnRefreshCustomDoc.UseVisualStyleBackColor = True
        '
        'lvwCustomPropsList
        '
        Me.lvwCustomPropsList.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwCustomPropsList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvwCustomPropsList.FullRowSelect = True
        Me.lvwCustomPropsList.GridLines = True
        Me.lvwCustomPropsList.HoverSelection = True
        Me.lvwCustomPropsList.Location = New System.Drawing.Point(11, 19)
        Me.lvwCustomPropsList.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.lvwCustomPropsList.Name = "lvwCustomPropsList"
        Me.lvwCustomPropsList.Size = New System.Drawing.Size(348, 176)
        Me.lvwCustomPropsList.TabIndex = 19
        Me.lvwCustomPropsList.UseCompatibleStateImageBehavior = False
        Me.lvwCustomPropsList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Property Name"
        Me.ColumnHeader1.Width = 103
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Current Value"
        Me.ColumnHeader2.Width = 244
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnRemoveWordCustomProperty)
        Me.GroupBox4.Location = New System.Drawing.Point(367, 143)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox4.Size = New System.Drawing.Size(176, 52)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Delete"
        '
        'btnRemoveWordCustomProperty
        '
        Me.btnRemoveWordCustomProperty.Enabled = False
        Me.btnRemoveWordCustomProperty.Location = New System.Drawing.Point(6, 19)
        Me.btnRemoveWordCustomProperty.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnRemoveWordCustomProperty.Name = "btnRemoveWordCustomProperty"
        Me.btnRemoveWordCustomProperty.Size = New System.Drawing.Size(154, 23)
        Me.btnRemoveWordCustomProperty.TabIndex = 3
        Me.btnRemoveWordCustomProperty.Text = "Delete Selected Property"
        Me.btnRemoveWordCustomProperty.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnModifyWordCustPropName)
        Me.GroupBox3.Controls.Add(Me.btnAddNewWordCustProp)
        Me.GroupBox3.Controls.Add(Me.btnModifyWordCustomApp)
        Me.GroupBox3.Location = New System.Drawing.Point(367, 29)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(166, 108)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Add/Edit"
        '
        'btnModifyWordCustPropName
        '
        Me.btnModifyWordCustPropName.Enabled = False
        Me.btnModifyWordCustPropName.Location = New System.Drawing.Point(7, 77)
        Me.btnModifyWordCustPropName.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnModifyWordCustPropName.Name = "btnModifyWordCustPropName"
        Me.btnModifyWordCustPropName.Size = New System.Drawing.Size(154, 23)
        Me.btnModifyWordCustPropName.TabIndex = 3
        Me.btnModifyWordCustPropName.Text = "Modify Name"
        Me.btnModifyWordCustPropName.UseVisualStyleBackColor = True
        '
        'btnAddNewWordCustProp
        '
        Me.btnAddNewWordCustProp.Enabled = False
        Me.btnAddNewWordCustProp.Location = New System.Drawing.Point(7, 48)
        Me.btnAddNewWordCustProp.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnAddNewWordCustProp.Name = "btnAddNewWordCustProp"
        Me.btnAddNewWordCustProp.Size = New System.Drawing.Size(155, 23)
        Me.btnAddNewWordCustProp.TabIndex = 1
        Me.btnAddNewWordCustProp.Text = "Add New Custom Property"
        Me.btnAddNewWordCustProp.UseVisualStyleBackColor = True
        '
        'btnModifyWordCustomApp
        '
        Me.btnModifyWordCustomApp.Location = New System.Drawing.Point(6, 19)
        Me.btnModifyWordCustomApp.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnModifyWordCustomApp.Name = "btnModifyWordCustomApp"
        Me.btnModifyWordCustomApp.Size = New System.Drawing.Size(155, 23)
        Me.btnModifyWordCustomApp.TabIndex = 2
        Me.btnModifyWordCustomApp.Text = "Modify Value Of Selected"
        Me.btnModifyWordCustomApp.UseVisualStyleBackColor = True
        '
        'tabFields
        '
        Me.tabFields.Controls.Add(Me.lblTask)
        Me.tabFields.Controls.Add(Me.grpUpdateChoices)
        Me.tabFields.Controls.Add(Me.progMarquee)
        Me.tabFields.Controls.Add(Me.progUpdateProgress)
        Me.tabFields.Controls.Add(Me.progOverallProgress)
        Me.tabFields.Location = New System.Drawing.Point(4, 22)
        Me.tabFields.Name = "tabFields"
        Me.tabFields.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFields.Size = New System.Drawing.Size(620, 460)
        Me.tabFields.TabIndex = 2
        Me.tabFields.Text = "Fields"
        Me.tabFields.UseVisualStyleBackColor = True
        '
        'grpUpdateChoices
        '
        Me.grpUpdateChoices.Controls.Add(Me.chkCheckAll)
        Me.grpUpdateChoices.Controls.Add(Me.btnStartUpdates)
        Me.grpUpdateChoices.Controls.Add(Me.chkHeadersFooters)
        Me.grpUpdateChoices.Controls.Add(Me.chkListOfFigures)
        Me.grpUpdateChoices.Controls.Add(Me.chkTOC)
        Me.grpUpdateChoices.Controls.Add(Me.chkMainBody)
        Me.grpUpdateChoices.Controls.Add(Me.btnStop)
        Me.grpUpdateChoices.Location = New System.Drawing.Point(6, 6)
        Me.grpUpdateChoices.Name = "grpUpdateChoices"
        Me.grpUpdateChoices.Size = New System.Drawing.Size(179, 260)
        Me.grpUpdateChoices.TabIndex = 17
        Me.grpUpdateChoices.TabStop = False
        Me.grpUpdateChoices.Text = "Regions to Update"
        '
        'chkMainBody
        '
        Me.chkMainBody.AutoSize = True
        Me.chkMainBody.Location = New System.Drawing.Point(23, 64)
        Me.chkMainBody.Name = "chkMainBody"
        Me.chkMainBody.Size = New System.Drawing.Size(106, 17)
        Me.chkMainBody.TabIndex = 0
        Me.chkMainBody.Text = "Main Body Fields"
        Me.chkMainBody.UseVisualStyleBackColor = True
        '
        'chkTOC
        '
        Me.chkTOC.AutoSize = True
        Me.chkTOC.Location = New System.Drawing.Point(23, 88)
        Me.chkTOC.Name = "chkTOC"
        Me.chkTOC.Size = New System.Drawing.Size(110, 17)
        Me.chkTOC.TabIndex = 1
        Me.chkTOC.Text = "Table of Contents"
        Me.chkTOC.UseVisualStyleBackColor = True
        '
        'chkListOfFigures
        '
        Me.chkListOfFigures.AutoSize = True
        Me.chkListOfFigures.Location = New System.Drawing.Point(23, 112)
        Me.chkListOfFigures.Name = "chkListOfFigures"
        Me.chkListOfFigures.Size = New System.Drawing.Size(102, 17)
        Me.chkListOfFigures.TabIndex = 2
        Me.chkListOfFigures.Text = "Table of Figures"
        Me.chkListOfFigures.UseVisualStyleBackColor = True
        '
        'chkHeadersFooters
        '
        Me.chkHeadersFooters.AutoSize = True
        Me.chkHeadersFooters.Location = New System.Drawing.Point(23, 136)
        Me.chkHeadersFooters.Name = "chkHeadersFooters"
        Me.chkHeadersFooters.Size = New System.Drawing.Size(125, 17)
        Me.chkHeadersFooters.TabIndex = 3
        Me.chkHeadersFooters.Text = "Headers and Footers"
        Me.chkHeadersFooters.UseVisualStyleBackColor = True
        '
        'btnStartUpdates
        '
        Me.btnStartUpdates.Location = New System.Drawing.Point(23, 182)
        Me.btnStartUpdates.Name = "btnStartUpdates"
        Me.btnStartUpdates.Size = New System.Drawing.Size(125, 23)
        Me.btnStartUpdates.TabIndex = 4
        Me.btnStartUpdates.Text = "GO !"
        Me.btnStartUpdates.UseVisualStyleBackColor = True
        '
        'lblTask
        '
        Me.lblTask.AutoSize = True
        Me.lblTask.Location = New System.Drawing.Point(191, 15)
        Me.lblTask.Name = "lblTask"
        Me.lblTask.Size = New System.Drawing.Size(13, 13)
        Me.lblTask.TabIndex = 18
        Me.lblTask.Text = ".."
        '
        'chkCheckAll
        '
        Me.chkCheckAll.AutoSize = True
        Me.chkCheckAll.Location = New System.Drawing.Point(23, 28)
        Me.chkCheckAll.Name = "chkCheckAll"
        Me.chkCheckAll.Size = New System.Drawing.Size(37, 17)
        Me.chkCheckAll.TabIndex = 11
        Me.chkCheckAll.Text = "All"
        Me.chkCheckAll.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 486)
        Me.Controls.Add(Me.tabsMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Word Fields"
        Me.GroupBox1.ResumeLayout(False)
        Me.tabsMain.ResumeLayout(False)
        Me.tabDocs.ResumeLayout(False)
        Me.tabDocs.PerformLayout()
        Me.tabProperties.ResumeLayout(False)
        Me.grpStandardProperties.ResumeLayout(False)
        Me.grpCustomProperties.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.tabFields.ResumeLayout(False)
        Me.tabFields.PerformLayout()
        Me.grpUpdateChoices.ResumeLayout(False)
        Me.grpUpdateChoices.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbxOpenWordDocs As System.Windows.Forms.ListBox
    Friend WithEvents btnRefreshOpenDocs As System.Windows.Forms.Button
    Friend WithEvents txtCurrentWordDoc As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSetActiveDoc As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents progUpdateProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents progOverallProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents progMarquee As System.Windows.Forms.ProgressBar
    Friend WithEvents tabsMain As System.Windows.Forms.TabControl
    Friend WithEvents tabDocs As System.Windows.Forms.TabPage
    Friend WithEvents tabProperties As System.Windows.Forms.TabPage
    Friend WithEvents grpStandardProperties As System.Windows.Forms.GroupBox
    Friend WithEvents grpCustomProperties As System.Windows.Forms.GroupBox
    Friend WithEvents tabFields As System.Windows.Forms.TabPage
    Friend WithEvents btnRefreshStdWordPropsList As System.Windows.Forms.Button
    Friend WithEvents btnModifyStdPropValue As System.Windows.Forms.Button
    Friend WithEvents lvwWordStdProperties As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnRefreshCustomDoc As System.Windows.Forms.Button
    Friend WithEvents lvwCustomPropsList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRemoveWordCustomProperty As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnModifyWordCustPropName As System.Windows.Forms.Button
    Friend WithEvents btnAddNewWordCustProp As System.Windows.Forms.Button
    Friend WithEvents btnModifyWordCustomApp As System.Windows.Forms.Button
    Friend WithEvents grpUpdateChoices As System.Windows.Forms.GroupBox
    Friend WithEvents btnStartUpdates As System.Windows.Forms.Button
    Friend WithEvents chkHeadersFooters As System.Windows.Forms.CheckBox
    Friend WithEvents chkListOfFigures As System.Windows.Forms.CheckBox
    Friend WithEvents chkTOC As System.Windows.Forms.CheckBox
    Friend WithEvents chkMainBody As System.Windows.Forms.CheckBox
    Friend WithEvents lblTask As System.Windows.Forms.Label
    Friend WithEvents chkCheckAll As System.Windows.Forms.CheckBox

End Class
