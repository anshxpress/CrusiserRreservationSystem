Imports System.Data
Imports System.Data.SqlClient

Public Class Crusier
    Private Property connetionString As String

    Private Property ad As SqlDataAdapter

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        Dim rdr As SqlDataReader = Nothing

        Dim con As SqlConnection = Nothing

        Dim cmd As SqlCommand = Nothing


        Dim cs As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=seaways;Integrated Security=True;"

        con = New SqlConnection(cs)

        con.Open()


        Dim ct As String = "select * from Crusier where CruiseNo=@find"


        cmd = New SqlCommand(ct)
        cmd.Connection = con
        cmd.Parameters.Add(
       New SqlParameter("@find", System.Data.SqlDbType.NChar, 10, "CruiseNo"))
        cmd.Parameters("@find").Value = CruiseNo.Text
        rdr = cmd.ExecuteReader()
        If Not rdr.Read Then
            MsgBox("Sorry ! No Records Found")
            CruiseNo.Text = ""
            CruiseNo.Focus()
        Else
            CruiseNo.Text = rdr.GetString(0)
            ArrivalTime.Text = rdr.GetString(2)
            DepartureTime.Text = rdr.GetString(1)

            CruisersTypeId.Text = rdr.GetString(3)
            SectorID.Text = rdr.GetString(4)

        End If

        If Not rdr Is Nothing Then
            rdr.Close()
        End If
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.CruiseNo.Enabled = True
        Me.CruiseNo.Text = ""
        Me.DepartureTime.Text = ""
        Me.ArrivalTime.Text = ""
        Me.CruisersTypeId.Text = ""
        Me.SectorID.Text = ""

        Me.CruisersTypeId.Focus()
    End Sub

    Private Sub NewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewRecord.Click
        Me.CruiseNo.Text = ""
        Me.DepartureTime.Text = ""
        Me.ArrivalTime.Text = ""
        Me.CruisersTypeId.Text = ""
        Me.SectorID.Text = ""

    End Sub

    Private Sub Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add.Click
        If Len(Trim(CruisersTypeId.Text)) = 0 Then
            MessageBox.Show("Please select Cruisers Type ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Len(Trim(CruiseNo.Text)) = 0 Then
            MessageBox.Show("Please enter Cruise No.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Len(Trim(SectorID.Text)) = 0 Then
            MessageBox.Show("Please select sector ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Len(Trim(DepartureTime.Text)) = 0 Then
            MessageBox.Show("Please enter Departure Time", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            If Len(Trim(ArrivalTime.Text)) = 0 Then
                MessageBox.Show("Please enter Arrival Time", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        Dim rdr As SqlDataReader = Nothing

        Dim con As SqlConnection = Nothing

        Dim cmd As SqlCommand = Nothing

        Dim cs As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=seaways;Integrated Security=True;"

        con = New SqlConnection(cs)

        con.Open()
        Dim ct As String = "select CruiseNo from Crusier where CruiseNo=@find"

        cmd = New SqlCommand(ct)
        cmd.Connection = con
        cmd.Parameters.Add(
       New SqlParameter("@find", System.Data.SqlDbType.NChar, 10, "CruiseNo"))
        cmd.Parameters("@find").Value = CruiseNo.Text
        rdr = cmd.ExecuteReader()

        If rdr.Read Then
            MessageBox.Show("Cruise No.Already Exists", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CruiseNo.Text = ""
            ArrivalTime.Text = ""
            DepartureTime.Text = ""

            CruisersTypeId.Text = ""
            SectorID.Text = ""
            If Not rdr Is Nothing Then
                rdr.Close()


            End If


        Else

            Dim ck As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=seaways;Integrated Security=True;"

            con = New SqlConnection(ck)

            con.Open()

            Dim cb As String = "insert into Crusier(CruiseNo,DepartureTime,ArrivalTime,CruisersTypeId,SectorID) VALUES (@INSERT1,@INSERT2,@INSERT3,@INSERT4,@INSERT5)"

            cmd =
            New SqlCommand(cb)

            cmd.Connection = con

            cmd.Parameters.Add(
            New SqlParameter("@INSERT1", System.Data.SqlDbType.NChar, 10, "CruiseNo"))

            cmd.Parameters.Add(
            New SqlParameter("@INSERT2", System.Data.SqlDbType.NChar, 10, "DepartureTime"))

            cmd.Parameters.Add(
            New SqlParameter("@INSERT3", System.Data.SqlDbType.NChar, 10, "ArrivalTime"))

            cmd.Parameters.Add(
            New SqlParameter("@INSERT4", System.Data.SqlDbType.NChar, 10, "CruisersTypeId"))

            cmd.Parameters.Add(
            New SqlParameter("@INSERT5", System.Data.SqlDbType.NChar, 10, "SectorID"))

            cmd.Parameters(
            "@INSERT1").Value = CruiseNo.Text



            cmd.Parameters(
            "@INSERT2").Value = DepartureTime.Text

            cmd.Parameters(
            "@INSERT3").Value = ArrivalTime.Text
            cmd.Parameters(
            "@INSERT4").Value = CruisersTypeId.Text
            cmd.Parameters(
            "@INSERT5").Value = SectorID.Text

            cmd.ExecuteReader()



            If con.State = ConnectionState.Open Then

                con.Close()

            End If

            con.Close()
            MsgBox("Successfully Added")

            Me.CruiseNo.Text = ""
            Me.DepartureTime.Text = ""
            Me.ArrivalTime.Text = ""
            Me.CruisersTypeId.Text = ""
            Me.SectorID.Text = ""
        End If
    End Sub

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        Dim rdr As SqlDataReader = Nothing

        Dim con As SqlConnection = Nothing

        Dim cmd As SqlCommand = Nothing
        Dim cz As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=seaways;Integrated Security=True;"

        con = New SqlConnection(cz)

        con.Open()
        Dim cd As String = "select ArrivalTime from Crusier,Reservations where Reservations.CruiseNo=Crusier.CruiseNo and ArrivalTime= '" & ArrivalTime.Text & "'"


        cmd = New SqlCommand(cd)

        cmd.Connection = con



        rdr = cmd.ExecuteReader()

        If rdr.Read Then
            MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.CruiseNo.Text = ""
            Me.DepartureTime.Text = ""
            Me.ArrivalTime.Text = ""
            Me.CruisersTypeId.Text = ""
            Me.SectorID.Text = ""





            If Not rdr Is Nothing Then
                rdr.Close()
            End If
            Exit Sub
        End If
        Dim cv As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=seaways;Integrated Security=True;"

        con = New SqlConnection(cv)

        con.Open()
        Dim ch As String = "select DepartureTime from Crusier,Reservations where reservations.CruiseNo=Crusier.CruiseNo and DepartureTime= '" & DepartureTime.Text & "'"

        cmd = New SqlCommand(ch)

        cmd.Connection = con



        rdr = cmd.ExecuteReader()

        If rdr.Read Then
            MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.CruiseNo.Text = ""
            Me.DepartureTime.Text = ""
            Me.ArrivalTime.Text = ""
            Me.CruisersTypeId.Text = ""
            Me.SectorID.Text = ""



            If Not rdr Is Nothing Then
                rdr.Close()
            End If
            Exit Sub
        End If
        Dim coz As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=seaways;Integrated Security=True;"

        con = New SqlConnection(coz)

        con.Open()
        Dim cxd As String = "select CruisersTypeId from Crusier,Reservations where reservations.CruiseNo=Crusier.CruiseNo and CruisersTypeId= '" & CruisersTypeId.Text & "'"

        cmd = New SqlCommand(cxd)

        cmd.Connection = con



        rdr = cmd.ExecuteReader()

        If rdr.Read Then
            MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.CruiseNo.Text = ""
            Me.DepartureTime.Text = ""
            Me.ArrivalTime.Text = ""
            Me.CruisersTypeId.Text = ""
            Me.SectorID.Text = ""




            If Not rdr Is Nothing Then
                rdr.Close()
            End If
            Exit Sub
        End If
        Dim cr As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=seaways;Integrated Security=True;"

        con = New SqlConnection(cr)

        con.Open()
        Dim cg As String = "select SectorID from Crusier,Reservations where reservations.CruiseNo=Crusier.CruiseNo and SectorID= '" & SectorID.Text & "'"

        cmd = New SqlCommand(cg)

        cmd.Connection = con



        rdr = cmd.ExecuteReader()

        If rdr.Read Then
            MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.CruiseNo.Text = ""
            Me.DepartureTime.Text = ""
            Me.ArrivalTime.Text = ""
            Me.CruisersTypeId.Text = ""
            Me.SectorID.Text = ""




            If Not rdr Is Nothing Then
                rdr.Close()
            End If
            Exit Sub
        End If
        Dim csf As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=seaways;Integrated Security=True;"

        con = New SqlConnection(csf)

        con.Open()
        Dim cdf As String = "select ArrivalTime from Crusier,ScheduleCruise where ScheduleCruise.CruiseNo=Crusier.CruiseNo and ArrivalTime= '" & ArrivalTime.Text & "'"

        cmd = New SqlCommand(cdf)

        cmd.Connection = con



        rdr = cmd.ExecuteReader()

        If rdr.Read Then
            MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.CruiseNo.Text = ""
            Me.DepartureTime.Text = ""
            Me.ArrivalTime.Text = ""
            Me.CruisersTypeId.Text = ""
            Me.SectorID.Text = ""




            If Not rdr Is Nothing Then
                rdr.Close()
            End If
            Exit Sub
        End If
        Dim cza As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=seaways;Integrated Security=True;"

        con = New SqlConnection(cza)

        con.Open()
        Dim cda As String = "select DepartureTime from Crusier,ScheduleCruise where ScheduleCruise.CruiseNo=Crusier.CruiseNo and DepartureTime= '" & DepartureTime.Text & "'"


        cmd = New SqlCommand(cda)

        cmd.Connection = con



        rdr = cmd.ExecuteReader()

        If rdr.Read Then
            MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.CruiseNo.Text = ""
            Me.DepartureTime.Text = ""
            Me.ArrivalTime.Text = ""
            Me.CruisersTypeId.Text = ""
            Me.SectorID.Text = ""





            If Not rdr Is Nothing Then
                rdr.Close()
            End If
            Exit Sub
        End If
        Dim czq As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=seaways;Integrated Security=True;"

        con = New SqlConnection(czq)

        con.Open()
        Dim cdw As String = "select CruisersTypeId from Crusier,ScheduleCruise where ScheduleCruise.CruiseNo=Crusier.CruiseNo and CruisersTypeId= '" & CruisersTypeId.Text & "'"


        cmd = New SqlCommand(cdw)

        cmd.Connection = con



        rdr = cmd.ExecuteReader()

        If rdr.Read Then
            MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.CruiseNo.Text = ""
            Me.DepartureTime.Text = ""
            Me.ArrivalTime.Text = ""
            Me.CruisersTypeId.Text = ""
            Me.SectorID.Text = ""



            If Not rdr Is Nothing Then
                rdr.Close()
            End If
            Exit Sub
        End If


        Dim czx As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=seaways;Integrated Security=True;"

        con = New SqlConnection(czx)

        con.Open()
        Dim cdl As String = "select SectorID from Crusier,ScheduleCruise where ScheduleCruise.CruiseNo=Crusier.CruiseNo and SectorID= '" & SectorID.Text & "'"


        cmd = New SqlCommand(cdl)

        cmd.Connection = con



        rdr = cmd.ExecuteReader()

        If rdr.Read Then
            MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.CruiseNo.Text = ""
            Me.DepartureTime.Text = ""
            Me.ArrivalTime.Text = ""
            Me.CruisersTypeId.Text = ""
            Me.SectorID.Text = ""



            If Not rdr Is Nothing Then
                rdr.Close()
            End If
            Exit Sub
        End If

        Dim cs As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=seaways;Integrated Security=True;"

        con = New SqlConnection(cs)

        con.Open()
        Dim ct As String = "select CruiseNo from Reservations where CruiseNo=@find"

        cmd = New SqlCommand(ct)
        cmd.Connection = con
        cmd.Parameters.Add(
       New SqlParameter("@find", System.Data.SqlDbType.NChar, 10, "CruiseNo"))
        cmd.Parameters("@find").Value = CruiseNo.Text
        rdr = cmd.ExecuteReader()

        If rdr.Read Then
            MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CruiseNo.Text = ""
            ArrivalTime.Text = ""
            DepartureTime.Text = ""

            CruisersTypeId.Text = ""
            SectorID.Text = ""
            If Not rdr Is Nothing Then
                rdr.Close()


            End If
            Exit Sub
        End If
        Dim cdh As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=seaways;Integrated Security=True;"

        con = New SqlConnection(cdh)

        con.Open()

        Dim cp As String = "select CruiseNo from ScheduleCruise where CruiseNo=@find"
        cmd = New SqlCommand(cp)
        cmd.Connection = con
        cmd.Parameters.Add(
       New SqlParameter("@find", System.Data.SqlDbType.NChar, 10, "CruiseNo"))
        cmd.Parameters("@find").Value = CruiseNo.Text
        rdr = cmd.ExecuteReader()

        If rdr.Read Then
            MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CruiseNo.Text = ""
            ArrivalTime.Text = ""
            DepartureTime.Text = ""

            CruisersTypeId.Text = ""
            SectorID.Text = ""
            If Not rdr Is Nothing Then
                rdr.Close()


            End If



        Else

            Dim RowsAffected As Integer = 0

            Dim cb As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=seaways;Integrated Security=True;"

            con = New SqlConnection(cb)

            con.Open()

            Dim ck As String = "delete from Crusier where CruiseNo=@DELETE1;;delete from Crusier where ArrivalTime=@DELETE2;delete from Crusier where DepartureTime=@DELETE3;delete from Crusier where CruisersTypeId=@DELETE4;delete from Crusier where SectorID=@DELETE5"


            cmd = New SqlCommand(ck)

            cmd.Connection = con

            cmd.Parameters.Add(New SqlParameter("@DELETE1", System.Data.SqlDbType.NChar, 10, "CruiseNo"))

            cmd.Parameters.Add(
            New SqlParameter("@DELETE2", System.Data.SqlDbType.NChar, 10, "ArrivalTime"))

            cmd.Parameters.Add(
            New SqlParameter("@DELETE3", System.Data.SqlDbType.NChar, 10, "DepartureTime"))

            cmd.Parameters.Add(
            New SqlParameter("@DELETE4", System.Data.SqlDbType.NChar, 10, "CruisersTypeId"))

            cmd.Parameters.Add(
           New SqlParameter("@DELETE5", System.Data.SqlDbType.NChar, 10, "SectorID"))


            cmd.Parameters("@DELETE1").Value = CruiseNo.Text

            cmd.Parameters(
            "@DELETE2").Value = ArrivalTime.Text


            cmd.Parameters(
            "@DELETE3").Value = DepartureTime.Text

            cmd.Parameters(
            "@DELETE4").Value = CruisersTypeId.Text

            cmd.Parameters(
           "@DELETE5").Value = SectorID.Text
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                MsgBox("Successfully Deleted")
                Me.CruiseNo.Text = ""
                Me.DepartureTime.Text = ""
                Me.ArrivalTime.Text = ""
                Me.CruisersTypeId.Text = ""
                Me.SectorID.Text = ""
            Else
                MsgBox("Record Not Found")
                Me.CruiseNo.Text = ""
                Me.DepartureTime.Text = ""
                Me.ArrivalTime.Text = ""
                Me.CruisersTypeId.Text = ""
                Me.SectorID.Text = ""
            End If


            cmd.ExecuteReader()
            If con.State = ConnectionState.Open Then

                con.Close()
            End If

            con.Close()
        End If

    End Sub

    Private Sub Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit.Click
        Dim rdr As SqlDataReader = Nothing

        Dim con As SqlConnection = Nothing

        Dim cmd As SqlCommand = Nothing


        Dim cs As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=seaways;Integrated Security=True;"

        con = New SqlConnection(cs)

        con.Open()

        Dim ct As String = "update Crusier set ArrivalTime=@UPDATE2,DepartureTime=@UPDATE3,CruisersTypeId=@UPDATE4,SectorID=@UPDATE5 where CruiseNo=@UPDATE1"

        cmd =
        New SqlCommand(ct)

        cmd.Connection = con

        cmd.Parameters.Add(
        New SqlParameter("@UPDATE1", System.Data.SqlDbType.NChar, 10, "CruiseNo"))



        cmd.Parameters.Add(
        New SqlParameter("@UPDATE2", System.Data.SqlDbType.NChar, 20, "ArrivalTime"))

        cmd.Parameters.Add(
        New SqlParameter("@UPDATE3", System.Data.SqlDbType.NChar, 10, "DepartureTime"))

        cmd.Parameters.Add(
        New SqlParameter("@UPDATE4", System.Data.SqlDbType.NChar, 10, "CruisersTypeId"))

        cmd.Parameters.Add(
       New SqlParameter("@UPDATE5", System.Data.SqlDbType.NChar, 10, "SectorID"))

        cmd.Parameters(
        "@UPDATE1").Value = CruiseNo.Text

        cmd.Parameters(
        "@UPDATE2").Value = ArrivalTime.Text

        cmd.Parameters(
        "@UPDATE3").Value = DepartureTime.Text

        cmd.Parameters(
        "@UPDATE4").Value = CruisersTypeId.Text

        cmd.Parameters(
       "@UPDATE5").Value = SectorID.Text
        cmd.ExecuteNonQuery()




        cmd.ExecuteReader()

        If con.State = ConnectionState.Open Then

        End If

        con.Close()
        Me.CruiseNo.Text = ""
        Me.DepartureTime.Text = ""
        Me.ArrivalTime.Text = ""
        Me.CruisersTypeId.Text = ""
        Me.SectorID.Text = ""

    End Sub
    Private Const ConnectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=seaways;Integrated Security=True;"

    Private ReadOnly Property Connection() As SqlConnection
        Get
            Dim ConnectionToFetch As New SqlConnection(ConnectionString)
            ConnectionToFetch.Open()
            Return ConnectionToFetch
        End Get
    End Property
    Public Function GetData() As DataView
        Dim SelectQry = "SELECT * FROM Crusier "
        Dim SampleSource As New DataSet
        Dim TableView As DataView
        Try
            Dim SampleCommand As New SqlCommand()
            Dim SampleDataAdapter = New SqlDataAdapter()
            SampleCommand.CommandText = SelectQry
            SampleCommand.Connection = Connection
            SampleDataAdapter.SelectCommand = SampleCommand
            SampleDataAdapter.Fill(SampleSource)
            TableView = SampleSource.Tables(0).DefaultView
        Catch ex As Exception
            Throw ex
        End Try
        Return TableView
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DataGridView1.Visible = True
        DataGridView1.Font = New Font("Century Schoolbook", 10, FontStyle.Bold)
        DataGridView1.DataSource = GetData()

    End Sub

    Private Sub SectorID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SectorID.SelectedIndexChanged

    End Sub
    Private Sub Crusier_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CruiseNo.Focus()
        Dim rdr As SqlDataReader = Nothing
        Dim con As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing
        Dim cs As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=seaways;Integrated Security=True;"

        con = New SqlConnection(cs)
        con.Open()
        Dim ct As String = "select CruisersTypeId from Cruisers "
        Dim cm As String = "select SectorID from Sector"
        cmd = New SqlCommand(ct)
        cmd.Connection = con

        rdr = cmd.ExecuteReader()

        While rdr.Read
            CruisersTypeId.Items.Add(rdr(0))
        End While
        con.Close()
        con.Open()

        cmd = New SqlCommand(cm)
        cmd.Connection = con

        rdr = cmd.ExecuteReader()

        While rdr.Read
            SectorID.Items.Add(rdr(0))

        End While
        con.Close()

        con.ConnectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=seaways;Integrated Security=True;"

        con.Open()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New SqlDataAdapter("select CruiseNo from Crusier", con)
        da.Fill(dt)
        Dim r As DataRow
        CruiseNo.AutoCompleteCustomSource.Clear()
        For Each r In dt.Rows
            CruiseNo.AutoCompleteCustomSource.Add(r.Item(0).ToString)
        Next
        con.Close()

        DataGridView1.Visible = False
    End Sub
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        ADMIN_Page.Show()

    End Sub
    Private Sub NewRecord_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles NewRecord.MouseHover



        ToolTip1.IsBalloon = True
        ToolTip1.UseAnimation = True
        ToolTip1.ToolTipTitle = ""
        ToolTip1.SetToolTip(NewRecord, "Enter new records")


    End Sub

    Private Sub Add_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Add.MouseHover
        ToolTip1.IsBalloon = True
        ToolTip1.UseAnimation = True
        ToolTip1.ToolTipTitle = ""
        ToolTip1.SetToolTip(Add, "save new records")
    End Sub

    Private Sub Edit_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Edit.MouseHover
        ToolTip1.IsBalloon = True
        ToolTip1.UseAnimation = True
        ToolTip1.ToolTipTitle = ""
        ToolTip1.SetToolTip(Edit, "update the records")
    End Sub

    Private Sub Submit_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Submit.MouseHover
        ToolTip1.IsBalloon = True
        ToolTip1.UseAnimation = True
        ToolTip1.ToolTipTitle = ""
        ToolTip1.SetToolTip(Submit, "get record related to CruiseNo. in other textboxes by entering that particular CruiseNo.")
    End Sub

    Private Sub Cancel_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cancel.MouseHover
        ToolTip1.IsBalloon = True
        ToolTip1.UseAnimation = True
        ToolTip1.ToolTipTitle = ""
        ToolTip1.SetToolTip(Cancel, "to cancel entered CruiseNo. in textbox")
    End Sub

    Private Sub Delete_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Delete.MouseHover
        ToolTip1.IsBalloon = True
        ToolTip1.UseAnimation = True
        ToolTip1.ToolTipTitle = ""
        ToolTip1.SetToolTip(Delete, "to delete the records")
    End Sub

    Private Sub Button1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        ToolTip1.IsBalloon = True
        ToolTip1.UseAnimation = True
        ToolTip1.ToolTipTitle = ""
        ToolTip1.SetToolTip(Button1, "to show all the records using datagridview")
    End Sub

    Private Sub Button2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseHover
        ToolTip1.IsBalloon = True
        ToolTip1.UseAnimation = True
        ToolTip1.ToolTipTitle = ""
        ToolTip1.SetToolTip(Button2, "for Exit")
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class