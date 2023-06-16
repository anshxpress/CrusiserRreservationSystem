Imports System.Data.SqlClient
Public Class signup

    Private Sub signup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("M")
        ComboBox1.Items.Add("F")
        ComboBox1.Text = "select"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox9.Text = "" Or ComboBox1.Text = "" Then
            MessageBox.Show("Please complete the required fields..", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TextBox1.Text = "Match" Then
            Try
                Dim connection1 As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=seaways;Integrated Security=True;")
                connection1.Open()
                Dim cmd1 As New SqlCommand
                cmd1.CommandText = "Insert into users(Username,Password,Name,Age,Sex,ContactNo) VALUES ('" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & ComboBox1.Text & "','" & TextBox9.Text & "')"
                cmd1.Connection = connection1
                cmd1.ExecuteReader()
                connection1.Close()
                MsgBox(" Account created successfully!!", MsgBoxStyle.Information, "Record Added = ")
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                ComboBox1.Text = ""
                TextBox9.Text = ""
                TextBox1.Text = ""

            Catch ex As Exception
                MsgBox(" Failed to creat account!!", MsgBoxStyle.Critical)
            End Try
        Else
            MessageBox.Show("Password not match... Try again", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox1.Text = ""
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        ComboBox1.Text = ""
        TextBox9.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        If TextBox4.Text = TextBox5.Text Then
            TextBox1.Text = "Match"
            TextBox1.ForeColor = Color.Green

        Else
            TextBox1.Text = "Not match"
            TextBox1.ForeColor = Color.Red
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) 

    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        Dim allowedchars As String = "abcdefghijklmnopqrstuvwxyz"
        If Not allowedchars.Contains(e.KeyChar.ToString.ToLower) Then
            MsgBox("Please Enter A Character Value!")
            e.KeyChar = ChrW(0)
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
        Dim allowednos As String = "1234567890"
        If Not allowednos.Contains(e.KeyChar.ToString) Then
            MsgBox("Please Enter A Number!")
            e.KeyChar = ChrW(0)
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress
        Dim allowednos As String = "1234567890"
        If Not allowednos.Contains(e.KeyChar.ToString) Then
            MsgBox("Please Enter A Number!")
            e.KeyChar = ChrW(0)
            e.Handled = True
        End If
    End Sub
End Class