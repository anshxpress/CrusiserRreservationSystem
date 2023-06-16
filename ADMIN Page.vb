Public Class ADMIN_Page

    Private Sub ReservationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservationToolStripMenuItem.Click
        Me.Hide()
        COLLECTION.Show()

    End Sub

    Private Sub CruisersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CruisersToolStripMenuItem.Click
        Me.Hide()
        cruiser.Show()

    End Sub

    Private Sub CrusierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrusierToolStripMenuItem.Click
        Me.Hide()
        Crusier.Show()


    End Sub

    Private Sub SectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SectorToolStripMenuItem.Click
        Me.Hide()
        Sector.Show()

    End Sub

    Private Sub AirlineScheduleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AirlineScheduleToolStripMenuItem.Click
        ScheduleCruise.Show()
        Me.Hide()

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub CancellationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancellationToolStripMenuItem.Click
        Me.Hide()
        Refund.Show()

    End Sub

    Private Sub ADMIN_Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Label3.Text = Format(Now, "dd-MMM-yyyy")
        Me.Label4.Text = Format(Now, "hh:mm")
    End Sub
End Class