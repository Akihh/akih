
Imports MySql.Data.MySqlClient

Module Module1
    Dim con As New MySqlConnection
    Dim reader As MySqlDataReader
    Dim mysqlcmd As MySqlCommand
    Dim host, uname, pwd, dbname As String
    Dim sqlquery As String

    Public Sub ConnectDbase()
        host = "127.0.01"
        dbname = "it2boop"
        uname = "root"
        pwd = "password"
        'check if connection is opem
        If Not con Is Nothing Then
            con.Close() 'close the dbaseconnection
            con.ConnectionString = "server =" & host & "; user id=" & uname &
             "; password = " & pwd & "; database=" & dbname & ""
            Try
                'open the connection
                con.Open()
                MessageBox.Show("Connected!")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If

    End Sub

    Public Sub SaveRecord()
        Dim fname, lname, course As String
        fname = Form1.txtfname.Text 'get value from form1 textboxes
        lname = Form1.txtlname.Text
        course = Form1.txtcourse.Text


        sqlquery = "INSERT INTO student(studFName, studLName, course)VALUES(@fname, @lname, @course)"
        'pass the query and connection to mysqlcommand
        mysqlcmd = New MySqlCommand(sqlquery, con)
        'add the parameter value
        mysqlcmd.Parameters.AddWithValue("@fname", fname)
        mysqlcmd.Parameters.AddWithValue("@lname", lname)
        mysqlcmd.Parameters.AddWithValue("@course", course)
        Try
            'execute the sql command
            mysqlcmd.ExecuteNonQuery()
            MsgBox("Record save successfully!")
        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message)
        Finally
            TextClear()
        End Try
    End Sub
    Sub TextClear()
        Form1.txtfname.Clear()
        Form1.txtlname.Clear()
        Form1.txtcourse.Clear()

    End Sub

    Public Sub SearchData()
        Dim uid As String
        uid = Form1.txtuserid.Text
        sqlquery = "SELECT * FROM student where studID= @uid"
        mysqlcmd = New MySqlCommand(sqlquery, con)
        mysqlcmd.Parameters.AddWithValue("@uid", uid)
        Try
            reader = mysqlcmd.ExecuteReader()
            If reader.Read Then
                Form1.txtuserid.Text = reader("studFName").ToString()
                Form1.txtfirst.Text = reader("studLName").ToString()
                Form1.txtstudcourse.Text = reader("course").ToString()
            Else
                MsgBox("No Record!")

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            reader.Close()
        End Try

    End Sub

End Module
