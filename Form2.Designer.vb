<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        cbocourse = New ComboBox()
        btnhome = New Button()
        btndisplay = New Button()
        dgvdata = New DataGridView()
        CType(dgvdata, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cbocourse
        ' 
        cbocourse.FormattingEnabled = True
        cbocourse.Location = New Point(89, 42)
        cbocourse.Name = "cbocourse"
        cbocourse.Size = New Size(149, 23)
        cbocourse.TabIndex = 0
        ' 
        ' btnhome
        ' 
        btnhome.Location = New Point(538, 339)
        btnhome.Name = "btnhome"
        btnhome.Size = New Size(151, 35)
        btnhome.TabIndex = 1
        btnhome.Text = "Back"
        btnhome.UseVisualStyleBackColor = True
        ' 
        ' btndisplay
        ' 
        btndisplay.Location = New Point(326, 36)
        btndisplay.Name = "btndisplay"
        btndisplay.Size = New Size(96, 33)
        btndisplay.TabIndex = 2
        btndisplay.Text = "Display"
        btndisplay.UseVisualStyleBackColor = True
        ' 
        ' dgvdata
        ' 
        dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvdata.Location = New Point(89, 75)
        dgvdata.Name = "dgvdata"
        dgvdata.RowTemplate.Height = 25
        dgvdata.Size = New Size(600, 241)
        dgvdata.TabIndex = 5
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgvdata)
        Controls.Add(btndisplay)
        Controls.Add(btnhome)
        Controls.Add(cbocourse)
        Name = "Form2"
        Text = "Form2"
        CType(dgvdata, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents cbocourse As ComboBox
    Friend WithEvents btnhome As Button
    Friend WithEvents btndisplay As Button
    Friend WithEvents dgvdata As DataGridView
End Class
