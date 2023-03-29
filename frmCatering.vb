Option Strict On 'You have to declare all of your variables 
Option Explicit On
Public Class frmCatering
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decCost As Decimal
        Dim decFinal As Decimal
        Dim cdecDsicount As Decimal = 5D
        Dim decLoyaltyPoints As Decimal
        Dim strOrder As String = ""
        Dim strPay As String = ""
        Dim strLoyaltyPoints As String = ""
        Dim intLoyaltyPoints As Integer

        '
        If IsNumeric(txtLoyaltyPoints.Text) Then
            intLoyaltyPoints = Convert.ToInt32(txtLoyaltyPoints.Text)
            strLoyaltyPoints = "after discount of " & intLoyaltyPoints.ToString() & " loyalty points."

            'Determine platter cost
            If radGourmetCheese.Checked Then
                decCost = 49.99D
                strOrder = "Cheese"
            ElseIf radPinwheelWraps.Checked Then
                decCost = 59.99D
                strOrder = "Wrap"
            ElseIf radVeggie.Checked Then
                decCost = 29.99D
                strOrder = "Veggie"
            ElseIf radSausageAndCheese.Checked Then
                decCost = 49.99D
                strOrder = "Sausage and Chicken"
            ElseIf radFruit.Checked Then
                decCost = 29.99D
                strOrder = "Fruit"
            End If

            If radPrePay.Checked Then
                strPay = " using Pre-Pay"
            ElseIf radPayUponPickup.Checked Then
                strPay = " with Pay upon Pickup"

            End If

            intLoyaltyPoints = Convert.ToInt32(intLoyaltyPoints / 10)
            MsgBox(intLoyaltyPoints)

            decLoyaltyPoints = (intLoyaltyPoints * cdecDsicount) / 100
            MsgBox(decLoyaltyPoints)

            If decLoyaltyPoints > 1 Then
                decLoyaltyPoints = 1
            End If

            MsgBox(decLoyaltyPoints)

            decFinal = decCost * (1 - decLoyaltyPoints)
            MsgBox(decFinal)

            lblPleasePay.Text = "Your order " & strOrder & " platter costs " & decFinal.ToString("C") & strPay & strLoyaltyPoints
        Else
            MsgBox("Please enter a valid number of points.", , "Input Error")
            Me.btnClear.PerformClick()
        End If

    End Sub

    Private Sub frmCatering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.btnClear.PerformClick()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtLoyaltyPoints.Text = ""
        txtLoyaltyPoints.Focus()
        lblPleasePay.Text = ""
        radGourmetCheese.Checked = True
        radPinwheelWraps.Checked = False
        radVeggie.Checked = False
        radSausageAndCheese.Checked = False
        radFruit.Checked = False
        radPrePay.Checked = True
        radPayUponPickup.Checked = False

    End Sub
End Class
