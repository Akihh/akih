<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        btninsert = New Button()
        txtcourse = New TextBox()
        txtlname = New TextBox()
        txtfname = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        btnupdate = New Button()
        btndelete = New Button()
        txtstudcourse = New TextBox()
        Button1 = New Button()
        Label7 = New Label()
        txtlast = New TextBox()
        txtfirst = New TextBox()
        txtuserid = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        btndisplay = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btninsert)
        GroupBox1.Controls.Add(txtcourse)
        GroupBox1.Controls.Add(txtlname)
        GroupBox1.Controls.Add(txtfname)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 33)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(325, 312)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Save Record"
        ' 
        ' btninsert
        ' 
        btninsert.Location = New Point(80, 198)
        btninsert.Name = "btninsert"
        btninsert.Size = New Size(114, 49)
        btninsert.TabIndex = 6
        btninsert.Text = "Insert Record"
        btninsert.UseVisualStyleBackColor = True
        ' 
        ' txtcourse
        ' 
        txtcourse.Location = New Point(136, 141)
        txtcourse.Name = "txtcourse"
        txtcourse.Size = New Size(100, 23)
        txtcourse.TabIndex = 5
        ' 
        ' txtlname
        ' 
        txtlname.Location = New Point(136, 90)
        txtlname.Name = "txtlname"
        txtlname.Size = New Size(100, 23)
        txtlname.TabIndex = 4
        ' 
        ' txtfname
        ' 
        txtfname.Location = New Point(136, 48)
        txtfname.Name = "txtfname"
        txtfname.Size = New Size(100, 23)
        txtfname.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(25, 141)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 15)
        Label3.TabIndex = 2
        Label3.Text = "Course:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(25, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 15)
        Label2.TabIndex = 1
        Label2.Text = "Lastname:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(25, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 15)
        Label1.TabIndex = 0
        Label1.Text = "FirstName:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnupdate)
        GroupBox2.Controls.Add(btndelete)
        GroupBox2.Controls.Add(txtstudcourse)
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(txtlast)
        GroupBox2.Controls.Add(txtfirst)
        GroupBox2.Controls.Add(txtuserid)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Location = New Point(397, 33)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(377, 364)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Save Record"
        ' 
        ' btnupdate
        ' 
        btnupdate.Location = New Point(25, 295)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(80, 40)
        btnupdate.TabIndex = 3
        btnupdate.Text = "Update"
        btnupdate.UseVisualStyleBackColor = True
        ' 
        ' btndelete
        ' 
        btndelete.Location = New Point(234, 295)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(75, 40)
        btndelete.TabIndex = 4
        btndelete.Text = "Delete"
        btndelete.UseVisualStyleBackColor = True
        ' 
        ' txtstudcourse
        ' 
        txtstudcourse.Location = New Point(136, 177)
        txtstudcourse.Name = "txtstudcourse"
        txtstudcourse.Size = New Size(100, 23)
        txtstudcourse.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(94, 227)
        Button1.Name = "Button1"
        Button1.Size = New Size(114, 49)
        Button1.TabIndex = 6
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(25, 180)
        Label7.Name = "Label7"
        Label7.Size = New Size(47, 15)
        Label7.TabIndex = 5
        Label7.Text = "Course:"
        ' 
        ' txtlast
        ' 
        txtlast.Location = New Point(136, 141)
        txtlast.Name = "txtlast"
        txtlast.Size = New Size(100, 23)
        txtlast.TabIndex = 5
        ' 
        ' txtfirst
        ' 
        txtfirst.Location = New Point(136, 90)
        txtfirst.Name = "txtfirst"
        txtfirst.Size = New Size(100, 23)
        txtfirst.TabIndex = 4
        ' 
        ' txtuserid
        ' 
        txtuserid.Location = New Point(136, 48)
        txtuserid.Name = "txtuserid"
        txtuserid.Size = New Size(100, 23)
        txtuserid.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(25, 141)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 15)
        Label4.TabIndex = 2
        Label4.Text = "LastName:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(25, 93)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 15)
        Label5.TabIndex = 1
        Label5.Text = "FirstName"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(25, 48)
        Label6.Name = "Label6"
        Label6.Size = New Size(62, 15)
        Label6.TabIndex = 0
        Label6.Text = "Student ID"
        ' 
        ' btndisplay
        ' 
        btndisplay.Location = New Point(397, 445)
        btndisplay.Name = "btndisplay"
        btndisplay.Size = New Size(134, 58)
        btndisplay.TabIndex = 2
        btndisplay.Text = "Display by Course"
        btndisplay.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(864, 569)
        Controls.Add(btndisplay)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btninsert As Button
    Friend WithEvents txtcourse As TextBox
    Friend WithEvents txtlname As TextBox
    Friend WithEvents txtfname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtlast As TextBox
    Friend WithEvents txtfirst As TextBox
    Friend WithEvents txtuserid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtstudcourse As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btndisplay As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndelete As Button
End Class
