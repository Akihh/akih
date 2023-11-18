
Imports K4os.Compression.LZ4.Streams
Imports Microsoft.VisualBasic.Devices
Imports MySql.Data.MySqlClient

Module Module1
    Dim con As New MySqlConnection
    Dim reader As MySqlDataReader
    Dim mysqlcmd As MySqlCommand
    Dim host, uname, pwd, dbname As String
    Dim sqlquery As String
    Dim adapter As New MySqlDataAdapter
    Dim dttable As New DataTable

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
                Form1.btnupdate.Enabled = True
                Form1.btndelete.Enabled = True
                Form1.txtfirst.Enabled = True
                Form1.txtlast.Enabled = True
                Form1.txtcourse.Enabled = True
            Else
                MsgBox("No Record!")

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            reader.Close()
        End Try

    End Sub

    Public Sub LoadAllData()
        sqlquery = "SELECT * FROM student"
        adapter = New MySqlDataAdapter(sqlquery, con)
        Try
            'display the record in your datagridview
            dttable = New DataTable
            adapter.Fill(dttable) 'pass the record from mysql to data table
            With Form2.dgvdata
                .DataSource = dttable 'set the source of datagridview
                .AutoResizeColumns()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try

    End Sub

    Public Sub LoadCourse()
        sqlquery = "select distinct course from student"
        Try
            mysqlcmd = New MySqlCommand(sqlquery, con)
            reader = mysqlcmd.ExecuteReader
            While reader.Read
                Form2.cbocourse.Items.Add(reader("course").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub


    Public Sub DisplayData(kurso As String)
        sqlquery = "SELECT * FROM student where course = @kurso"
        adapter = New MySqlDataAdapter(sqlquery, con)
        adapter.SelectCommand.Parameters.AddWithValue("@kurso", kurso)

        Try
            'display the record in your datagridview
            dttable = New DataTable
            adapter.Fill(dttable) 'pass the record from mysql to data table
            With Form2.dgvdata
                .DataSource = dttable 'set the source of datagridview
                .AutoResizeColumns()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try

    End Sub


    Public Sub UpdateRecord(studId As String, fname As String, lname As String, course As String)
        sqlquery = "UPDATE student set studFname = @fname, studLname = @lname, course = @course where studID = @studID"
        Try
            Using cmd As New MySqlCommand(sqlquery, con)
                cmd.Parameters.AddWithValue("@fname", fname)
                cmd.Parameters.AddWithValue("@lname", lname)
                cmd.Parameters.AddWithValue("@course", course)
                cmd.Parameters.AddWithValue("@studID", studId)
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("Update Successful!", vbInformation, "Update Message")
        Catch ex As Exception
            MsgBox("Error:" & ex.Message, vbInformation, "Error Message")
        Finally
            Form1.txtfirst.Clear()
            Form1.txtlast.Clear()
            Form1.txtstudcourse.Clear()
            Form1.txtuserid.Clear()

        End Try
    End Sub

    Public Sub DeleteRecord(studID As String)
        sqlquery = "delete from student where StudID = @studID"
        Try
            Using cmd As New MySqlCommand(sqlquery, con)
                cmd.Parameters.AddWithValue("@studID", studID)
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("Deletion Successful!", vbInformation, "Delete Message")
        Catch ex As Exception
            MsgBox("Error:" & ex.Message, vbInformation, "Error Message")
        Finally
            Form1.txtfirst.Clear()
            Form1.txtlast.Clear()
            Form1.txtstudcourse.Clear()
            Form1.txtuserid.Clear()

        End Try
    End Sub
End Module
