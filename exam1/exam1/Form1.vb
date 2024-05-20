Imports MySql.Data.MySqlClient

Module Module1
    Public cn As New MySqlConnection
    Public cm As New MySqlCommand
    Public cm1 As New MySqlCommand
    Public dr As MySqlDataReader
    Public dt As New DataTable
    Public dt1 As New DataTable
    Public da As MySqlDataAdapter
    Public da1 As MySqlDataAdapter
    Public ds As DataSet
    Public Function ConnectToDB() As MySqlConnection
        Dim connection As New MySqlConnection
        Try
            connection.ConnectionString = "server=localhost; user id=root; password=; database=exam"
            connection.Open()
            Return connection
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

End Module

Module DBConnection

    Public Function strconnection() As MySqlConnection
        Return New MySqlConnection("server=localhost; user id=root; password=; database=exam")
    End Function

    Public strcon As MySqlConnection = strconnection()

    Public result As String
    Public cmd As New MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable

    Public UserType As String

    Public Sub create(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Failed to save data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Data saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

    Public Sub reload(ByVal sql As String, ByVal DTG As Object)
        Try
            If DTG Is Nothing Then
                MessageBox.Show("Error: The DataGridView object is null.")
                Return
            End If

            dt = New DataTable
            strcon.Open()


            If da Is Nothing Then
                da = New MySqlDataAdapter
            End If


            

            With cmd
                .Connection = strcon
                .CommandText = sql
            End With

            da.SelectCommand = cmd
            da.Fill(dt)
            DTG.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
            If da IsNot Nothing Then
                da.Dispose()
            End If
        End Try
    End Sub


    Public Sub updates(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Data failed to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Data updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

    Public Sub delete(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Data failed to delete in database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Data deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

End Module
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadCourseData()
        LoadSubjectData()
        DataGridView1.Columns.Add("Column1", "Subject_id")
        DataGridView1.Columns.Add("Column2", "Lecturer")

    End Sub

    Private Sub LoadCourseData()

        Dim sql As String = "SELECT Course_name FROM courses"

        reload(sql, course_cbo)


        course_cbo.DisplayMember = "Course_name"
    End Sub


    Private Sub course_cbo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles course_cbo.SelectedIndexChanged
        If course_cbo.SelectedItem IsNot Nothing Then
            Dim selectedCourseId As String = course_cbo.SelectedValue.ToString()
            ' Call LoadStudentData with the selected course ID
            LoadStudentData(selectedCourseId)
        End If
    End Sub


    Private Sub LoadStudentData(courseId As String)

        Dim sql As String = "SELECT Stud_name FROM students WHERE course = @courseId"
        reload(sql, name_cbo)
        name_cbo.DisplayMember = "Stud_name"
    End Sub


    Private Sub LoadSubjectData()
        Dim sql As String = "SELECT subjects.subject_id, subjects.subject_name, lecturer.lecturer_name " &
                            "FROM subjects " &
                            "INNER JOIN lecturer ON subjects.lecturer = lecturer.lecturer_id"

        reload(sql, sub_cbo)
        sub_cbo.DisplayMember = "subject_name"
        sub_cbo.ValueMember = "subject_id"
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        If course_cbo.SelectedItem Is Nothing OrElse name_cbo.SelectedItem Is Nothing OrElse course_cbo.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a course, a student, and a subject to enroll.")
            Return
        End If

        Dim selectedCourse As String = course_cbo.SelectedItem.ToString()
        Dim selectedStudent As String = name_cbo.SelectedItem.ToString()

        ' Cast the selected item to DataRowView to access its fields
        Dim selectedSubjectRow As DataRowView = DirectCast(sub_cbo.SelectedItem, DataRowView)
        Dim selectedSubjectId As String = selectedSubjectRow("subject_id").ToString()
        Dim selectedSubjectName As String = selectedSubjectRow("subject_name").ToString()
        Dim selectedLecturerName As String = selectedSubjectRow("lecturer_name").ToString()


        DataGridView1.Rows.Add(selectedSubjectId, selectedLecturerName)
    End Sub


    Private Sub save(sender As Object, e As EventArgs) Handles save_btn.Click
        If course_cbo.SelectedItem Is Nothing OrElse name_cbo.SelectedItem Is Nothing OrElse course_cbo.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a course, a student, and a subject to enroll.")
            Return
        End If

        Dim selectedStudentName As String = name_cbo.Text

        ' Fetch student_id corresponding to the selected student name
        Dim selectedStudentId As String = GetStudentId(selectedStudentName)

        ' Iterate over DataGridView rows and insert data into student_subject table
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim subjectId As String = row.Cells("Column1").Value

            ' Insert data into student_subject table with student_id and subject_id
            InsertStudentSubject(selectedStudentId, subjectId)
            

        Next
        MessageBox.Show("Data inserted Successfully", "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        DataGridView1.Rows.Clear()
    End Sub

    Private Function GetStudentId(studentName As String) As String
        Dim studentId As String = ""

        ' Query to get student_id from students table based on student_name
        Dim sql As String = "SELECT stud_id FROM students WHERE Stud_name = @studentName"
        Using connection As New MySqlConnection("server=localhost; user id=root; password=; database=exam")
            Using command As New MySqlCommand(sql, connection)
                command.Parameters.AddWithValue("@studentName", studentName)
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    studentId = reader("Stud_id").ToString()
                    Return studentId
                End If
            End Using
        End Using

        Return studentId
    End Function

    Private Sub InsertStudentSubject(studentId As String, subjectId As String)
        ' Insert data into student_subject table with student_id and subject_id
        Dim sql As String = "INSERT INTO student_subject (student_id, subject_id) VALUES (@studentId, @subjectId)"
        Using connection As New MySqlConnection("server=localhost; user id=root; password=; database=exam")
            Using command As New MySqlCommand(sql, connection)
                command.Parameters.AddWithValue("@studentId", studentId)
                command.Parameters.AddWithValue("@subjectId", subjectId)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub



End Class