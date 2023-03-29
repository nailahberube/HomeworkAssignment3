<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatering
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.radGourmetCheese = New System.Windows.Forms.RadioButton()
        Me.radPinwheelWraps = New System.Windows.Forms.RadioButton()
        Me.radVeggie = New System.Windows.Forms.RadioButton()
        Me.radSausageAndCheese = New System.Windows.Forms.RadioButton()
        Me.radFruit = New System.Windows.Forms.RadioButton()
        Me.grpCateringPlatters = New System.Windows.Forms.GroupBox()
        Me.grpPayOptions = New System.Windows.Forms.GroupBox()
        Me.radPrePay = New System.Windows.Forms.RadioButton()
        Me.radPayUponPickup = New System.Windows.Forms.RadioButton()
        Me.lblLoyaltyPoints = New System.Windows.Forms.Label()
        Me.lblPleasePay = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtLoyaltyPoints = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpCateringPlatters.SuspendLayout()
        Me.grpPayOptions.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(59, 19)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(146, 58)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "  Catering" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Star Market" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'radGourmetCheese
        '
        Me.radGourmetCheese.AutoSize = True
        Me.radGourmetCheese.Location = New System.Drawing.Point(6, 34)
        Me.radGourmetCheese.Name = "radGourmetCheese"
        Me.radGourmetCheese.Size = New System.Drawing.Size(209, 24)
        Me.radGourmetCheese.TabIndex = 2
        Me.radGourmetCheese.TabStop = True
        Me.radGourmetCheese.Text = "Gourmet Cheese $49.99"
        Me.radGourmetCheese.UseVisualStyleBackColor = True
        '
        'radPinwheelWraps
        '
        Me.radPinwheelWraps.AutoSize = True
        Me.radPinwheelWraps.Location = New System.Drawing.Point(6, 64)
        Me.radPinwheelWraps.Name = "radPinwheelWraps"
        Me.radPinwheelWraps.Size = New System.Drawing.Size(200, 24)
        Me.radPinwheelWraps.TabIndex = 3
        Me.radPinwheelWraps.TabStop = True
        Me.radPinwheelWraps.Text = "Pinwheel Wraps $59.99"
        Me.radPinwheelWraps.UseVisualStyleBackColor = True
        '
        'radVeggie
        '
        Me.radVeggie.AutoSize = True
        Me.radVeggie.Location = New System.Drawing.Point(6, 94)
        Me.radVeggie.Name = "radVeggie"
        Me.radVeggie.Size = New System.Drawing.Size(137, 24)
        Me.radVeggie.TabIndex = 4
        Me.radVeggie.TabStop = True
        Me.radVeggie.Text = "Veggie $29.99"
        Me.radVeggie.UseVisualStyleBackColor = True
        '
        'radSausageAndCheese
        '
        Me.radSausageAndCheese.AutoSize = True
        Me.radSausageAndCheese.Location = New System.Drawing.Point(6, 124)
        Me.radSausageAndCheese.Name = "radSausageAndCheese"
        Me.radSausageAndCheese.Size = New System.Drawing.Size(241, 24)
        Me.radSausageAndCheese.TabIndex = 5
        Me.radSausageAndCheese.TabStop = True
        Me.radSausageAndCheese.Text = "Sausage and Cheese $49.99"
        Me.radSausageAndCheese.UseVisualStyleBackColor = True
        '
        'radFruit
        '
        Me.radFruit.AutoSize = True
        Me.radFruit.Location = New System.Drawing.Point(6, 154)
        Me.radFruit.Name = "radFruit"
        Me.radFruit.Size = New System.Drawing.Size(119, 24)
        Me.radFruit.TabIndex = 6
        Me.radFruit.TabStop = True
        Me.radFruit.Text = "Fruit $29.99"
        Me.radFruit.UseVisualStyleBackColor = True
        '
        'grpCateringPlatters
        '
        Me.grpCateringPlatters.BackColor = System.Drawing.Color.PapayaWhip
        Me.grpCateringPlatters.Controls.Add(Me.radGourmetCheese)
        Me.grpCateringPlatters.Controls.Add(Me.radFruit)
        Me.grpCateringPlatters.Controls.Add(Me.radPinwheelWraps)
        Me.grpCateringPlatters.Controls.Add(Me.radSausageAndCheese)
        Me.grpCateringPlatters.Controls.Add(Me.radVeggie)
        Me.grpCateringPlatters.Location = New System.Drawing.Point(58, 103)
        Me.grpCateringPlatters.Name = "grpCateringPlatters"
        Me.grpCateringPlatters.Size = New System.Drawing.Size(270, 198)
        Me.grpCateringPlatters.TabIndex = 7
        Me.grpCateringPlatters.TabStop = False
        Me.grpCateringPlatters.Text = "GroupBox1"
        '
        'grpPayOptions
        '
        Me.grpPayOptions.BackColor = System.Drawing.Color.PapayaWhip
        Me.grpPayOptions.Controls.Add(Me.radPayUponPickup)
        Me.grpPayOptions.Controls.Add(Me.radPrePay)
        Me.grpPayOptions.Location = New System.Drawing.Point(91, 324)
        Me.grpPayOptions.Name = "grpPayOptions"
        Me.grpPayOptions.Size = New System.Drawing.Size(200, 100)
        Me.grpPayOptions.TabIndex = 8
        Me.grpPayOptions.TabStop = False
        Me.grpPayOptions.Text = "GroupBox1"
        '
        'radPrePay
        '
        Me.radPrePay.AutoSize = True
        Me.radPrePay.Location = New System.Drawing.Point(7, 26)
        Me.radPrePay.Name = "radPrePay"
        Me.radPrePay.Size = New System.Drawing.Size(89, 24)
        Me.radPrePay.TabIndex = 0
        Me.radPrePay.TabStop = True
        Me.radPrePay.Text = "Pre-Pay"
        Me.radPrePay.UseVisualStyleBackColor = True
        '
        'radPayUponPickup
        '
        Me.radPayUponPickup.AutoSize = True
        Me.radPayUponPickup.Location = New System.Drawing.Point(7, 57)
        Me.radPayUponPickup.Name = "radPayUponPickup"
        Me.radPayUponPickup.Size = New System.Drawing.Size(151, 24)
        Me.radPayUponPickup.TabIndex = 1
        Me.radPayUponPickup.TabStop = True
        Me.radPayUponPickup.Text = "Pay upon Pickup"
        Me.radPayUponPickup.UseVisualStyleBackColor = True
        '
        'lblLoyaltyPoints
        '
        Me.lblLoyaltyPoints.AutoSize = True
        Me.lblLoyaltyPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoyaltyPoints.Location = New System.Drawing.Point(464, 245)
        Me.lblLoyaltyPoints.Name = "lblLoyaltyPoints"
        Me.lblLoyaltyPoints.Size = New System.Drawing.Size(142, 22)
        Me.lblLoyaltyPoints.TabIndex = 9
        Me.lblLoyaltyPoints.Text = "Loyalty Points:"
        '
        'lblPleasePay
        '
        Me.lblPleasePay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPleasePay.Location = New System.Drawing.Point(173, 445)
        Me.lblPleasePay.Name = "lblPleasePay"
        Me.lblPleasePay.Size = New System.Drawing.Size(515, 48)
        Me.lblPleasePay.TabIndex = 10
        Me.lblPleasePay.Text = "$888.88"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(452, 324)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(107, 34)
        Me.btnCalculate.TabIndex = 11
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(619, 324)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(104, 34)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtLoyaltyPoints
        '
        Me.txtLoyaltyPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoyaltyPoints.Location = New System.Drawing.Point(633, 245)
        Me.txtLoyaltyPoints.Name = "txtLoyaltyPoints"
        Me.txtLoyaltyPoints.Size = New System.Drawing.Size(55, 26)
        Me.txtLoyaltyPoints.TabIndex = 13
        Me.txtLoyaltyPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HomeworkAssignment3.My.Resources.Resources.platter
        Me.PictureBox1.Location = New System.Drawing.Point(410, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(337, 202)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 445)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Please Pay: "
        '
        'frmCatering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(762, 494)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtLoyaltyPoints)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblPleasePay)
        Me.Controls.Add(Me.lblLoyaltyPoints)
        Me.Controls.Add(Me.grpPayOptions)
        Me.Controls.Add(Me.grpCateringPlatters)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmCatering"
        Me.Text = "frmCatering"
        Me.grpCateringPlatters.ResumeLayout(False)
        Me.grpCateringPlatters.PerformLayout()
        Me.grpPayOptions.ResumeLayout(False)
        Me.grpPayOptions.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents radGourmetCheese As RadioButton
    Friend WithEvents radPinwheelWraps As RadioButton
    Friend WithEvents radVeggie As RadioButton
    Friend WithEvents radSausageAndCheese As RadioButton
    Friend WithEvents radFruit As RadioButton
    Friend WithEvents grpCateringPlatters As GroupBox
    Friend WithEvents grpPayOptions As GroupBox
    Friend WithEvents radPayUponPickup As RadioButton
    Friend WithEvents radPrePay As RadioButton
    Friend WithEvents lblLoyaltyPoints As Label
    Friend WithEvents lblPleasePay As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtLoyaltyPoints As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
End Class
