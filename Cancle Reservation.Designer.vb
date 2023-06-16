<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cancle_Reservation
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cancle_Reservation))
        Me.AirwayClass = New System.Windows.Forms.TextBox()
        Me.RefundTicket = New System.Windows.Forms.Button()
        Me.Source = New System.Windows.Forms.TextBox()
        Me.Destination = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GetDetails = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.Fare = New System.Windows.Forms.TextBox()
        Me.AmtRefund = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.RStatus = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TravelDate = New System.Windows.Forms.TextBox()
        Me.Gender = New System.Windows.Forms.TextBox()
        Me.CruiseNo = New System.Windows.Forms.TextBox()
        Me.Age = New System.Windows.Forms.TextBox()
        Me.Lname = New System.Windows.Forms.TextBox()
        Me.PnrNo = New System.Windows.Forms.TextBox()
        Me.Fname = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AirwayClass
        '
        Me.AirwayClass.Location = New System.Drawing.Point(748, 546)
        Me.AirwayClass.Margin = New System.Windows.Forms.Padding(4)
        Me.AirwayClass.Name = "AirwayClass"
        Me.AirwayClass.Size = New System.Drawing.Size(132, 22)
        Me.AirwayClass.TabIndex = 67
        '
        'RefundTicket
        '
        Me.RefundTicket.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RefundTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefundTicket.Location = New System.Drawing.Point(1161, 430)
        Me.RefundTicket.Margin = New System.Windows.Forms.Padding(4)
        Me.RefundTicket.Name = "RefundTicket"
        Me.RefundTicket.Size = New System.Drawing.Size(147, 78)
        Me.RefundTicket.TabIndex = 66
        Me.RefundTicket.Text = "&Print Refund  Receipt"
        Me.RefundTicket.UseVisualStyleBackColor = False
        '
        'Source
        '
        Me.Source.Location = New System.Drawing.Point(456, 318)
        Me.Source.Margin = New System.Windows.Forms.Padding(4)
        Me.Source.Name = "Source"
        Me.Source.Size = New System.Drawing.Size(132, 22)
        Me.Source.TabIndex = 65
        '
        'Destination
        '
        Me.Destination.Location = New System.Drawing.Point(815, 318)
        Me.Destination.Margin = New System.Windows.Forms.Padding(4)
        Me.Destination.Name = "Destination"
        Me.Destination.Size = New System.Drawing.Size(132, 22)
        Me.Destination.TabIndex = 64
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(280, 321)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 20)
        Me.Label14.TabIndex = 63
        Me.Label14.Text = "Source"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(679, 322)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 20)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "Destination"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(929, 140)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 39)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GetDetails
        '
        Me.GetDetails.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GetDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GetDetails.Location = New System.Drawing.Point(764, 142)
        Me.GetDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.GetDetails.Name = "GetDetails"
        Me.GetDetails.Size = New System.Drawing.Size(128, 38)
        Me.GetDetails.TabIndex = 60
        Me.GetDetails.Text = "Get Details"
        Me.GetDetails.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(1161, 260)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(147, 78)
        Me.Cancel.TabIndex = 59
        Me.Cancel.Text = "&Cancel Reservation"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.Location = New System.Drawing.Point(1161, 594)
        Me.button3.Margin = New System.Windows.Forms.Padding(4)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(147, 89)
        Me.button3.TabIndex = 58
        Me.button3.Text = "Back"
        Me.button3.UseVisualStyleBackColor = False
        '
        'Fare
        '
        Me.Fare.Location = New System.Drawing.Point(456, 667)
        Me.Fare.Margin = New System.Windows.Forms.Padding(4)
        Me.Fare.Name = "Fare"
        Me.Fare.Size = New System.Drawing.Size(132, 22)
        Me.Fare.TabIndex = 57
        '
        'AmtRefund
        '
        Me.AmtRefund.ForeColor = System.Drawing.Color.Red
        Me.AmtRefund.Location = New System.Drawing.Point(896, 663)
        Me.AmtRefund.Margin = New System.Windows.Forms.Padding(4)
        Me.AmtRefund.Name = "AmtRefund"
        Me.AmtRefund.Size = New System.Drawing.Size(132, 22)
        Me.AmtRefund.TabIndex = 56
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(640, 667)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(137, 20)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "Refund Amount"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(781, 431)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 17)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "(Last Name)"
        '
        'RStatus
        '
        Me.RStatus.Location = New System.Drawing.Point(456, 609)
        Me.RStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.RStatus.Name = "RStatus"
        Me.RStatus.Size = New System.Drawing.Size(132, 22)
        Me.RStatus.TabIndex = 52
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(476, 431)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 17)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "(First Name)"
        '
        'TravelDate
        '
        Me.TravelDate.Location = New System.Drawing.Point(456, 550)
        Me.TravelDate.Margin = New System.Windows.Forms.Padding(4)
        Me.TravelDate.Name = "TravelDate"
        Me.TravelDate.Size = New System.Drawing.Size(117, 22)
        Me.TravelDate.TabIndex = 51
        '
        'Gender
        '
        Me.Gender.Location = New System.Drawing.Point(748, 487)
        Me.Gender.Margin = New System.Windows.Forms.Padding(4)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(81, 22)
        Me.Gender.TabIndex = 50
        '
        'CruiseNo
        '
        Me.CruiseNo.Location = New System.Drawing.Point(456, 256)
        Me.CruiseNo.Margin = New System.Windows.Forms.Padding(4)
        Me.CruiseNo.Name = "CruiseNo"
        Me.CruiseNo.Size = New System.Drawing.Size(132, 22)
        Me.CruiseNo.TabIndex = 49
        '
        'Age
        '
        Me.Age.Location = New System.Drawing.Point(456, 487)
        Me.Age.Margin = New System.Windows.Forms.Padding(4)
        Me.Age.Name = "Age"
        Me.Age.Size = New System.Drawing.Size(73, 22)
        Me.Age.TabIndex = 48
        '
        'Lname
        '
        Me.Lname.Location = New System.Drawing.Point(748, 385)
        Me.Lname.Margin = New System.Windows.Forms.Padding(4)
        Me.Lname.Name = "Lname"
        Me.Lname.Size = New System.Drawing.Size(183, 22)
        Me.Lname.TabIndex = 47
        '
        'PnrNo
        '
        Me.PnrNo.Location = New System.Drawing.Point(537, 143)
        Me.PnrNo.Margin = New System.Windows.Forms.Padding(4)
        Me.PnrNo.Name = "PnrNo"
        Me.PnrNo.Size = New System.Drawing.Size(132, 22)
        Me.PnrNo.TabIndex = 46
        '
        'Fname
        '
        Me.Fname.Location = New System.Drawing.Point(456, 385)
        Me.Fname.Margin = New System.Windows.Forms.Padding(4)
        Me.Fname.Name = "Fname"
        Me.Fname.Size = New System.Drawing.Size(167, 22)
        Me.Fname.TabIndex = 45
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(280, 609)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 20)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Status"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(280, 672)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 20)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Amount Paid"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(280, 550)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 20)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Travel Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(648, 555)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 20)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Class"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(280, 487)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 20)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Age"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(648, 492)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(280, 385)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 20)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Passenger"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(280, 260)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Cruise No."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(280, 148)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 20)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Enter PNR No."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(528, 46)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(499, 46)
        Me.Label15.TabIndex = 69
        Me.Label15.Text = "CANCEL RESERVATION"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(271, 194)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(224, 20)
        Me.Label16.TabIndex = 70
        Me.Label16.Text = "*Enter Security Password"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(537, 187)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 22)
        Me.TextBox1.TabIndex = 71
        Me.TextBox1.UseSystemPasswordChar = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(284, 741)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(301, 17)
        Me.Label17.TabIndex = 72
        Me.Label17.Text = "*Genereted by You on Reservation Time"
        '
        'Cancle_Reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1800, 898)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.AirwayClass)
        Me.Controls.Add(Me.RefundTicket)
        Me.Controls.Add(Me.Source)
        Me.Controls.Add(Me.Destination)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GetDetails)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.Fare)
        Me.Controls.Add(Me.AmtRefund)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.RStatus)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TravelDate)
        Me.Controls.Add(Me.Gender)
        Me.Controls.Add(Me.CruiseNo)
        Me.Controls.Add(Me.Age)
        Me.Controls.Add(Me.Lname)
        Me.Controls.Add(Me.PnrNo)
        Me.Controls.Add(Me.Fname)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Cancle_Reservation"
        Me.Text = "Cancle_Reservation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AirwayClass As System.Windows.Forms.TextBox
    Friend WithEvents RefundTicket As System.Windows.Forms.Button
    Friend WithEvents Source As System.Windows.Forms.TextBox
    Friend WithEvents Destination As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GetDetails As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents button3 As System.Windows.Forms.Button
    Friend WithEvents Fare As System.Windows.Forms.TextBox
    Friend WithEvents AmtRefund As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents RStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TravelDate As System.Windows.Forms.TextBox
    Friend WithEvents Gender As System.Windows.Forms.TextBox
    Friend WithEvents CruiseNo As System.Windows.Forms.TextBox
    Friend WithEvents Age As System.Windows.Forms.TextBox
    Friend WithEvents Lname As System.Windows.Forms.TextBox
    Friend WithEvents PnrNo As System.Windows.Forms.TextBox
    Friend WithEvents Fname As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
