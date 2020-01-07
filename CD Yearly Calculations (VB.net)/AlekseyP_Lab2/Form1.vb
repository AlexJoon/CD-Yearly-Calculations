Option Strict On
Option Explicit On

'Made by: Aleksey Przhevalskiy

Public Class Form1

    'Making the scope of my variables to the public class and limited to a certain sub-procedure.
    Dim DepositAmt As Double
    Dim InterestRate As Double
    Dim InterestRateCalc As Double

    Dim SelectionChange As Integer

    'Changing the scope for my Calculate Year 1-3 Variables .
    Dim FinalYear1Amt As Double
    Dim Year2Amt As Double
    Dim Year3Amt As Double

    'Changing the scope for my Calculate Year 4-6 Variables.
    Dim Year4Amt As Double
    Dim Year5Amt As Double
    Dim Year6Amt As Double

    'Changing the scope for my Calculate Year 7-10 Variables.
    Dim Year7Amt As Double
    Dim Year8Amt As Double
    Dim Year9Amt As Double
    Dim Year10Amt As Double


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDeposit.Clear()
        txtRate.Clear()
        lstOutYearly.Items.Clear()

        btnCalcYear1.Enabled = True
        btnCalcYear2.Enabled = False
        btnCalcYear3.Enabled = False

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click

        Dim QuitSelected As Integer
        QuitSelected = MessageBox.Show("Are you sure you want to exit?", "Exiting..", MessageBoxButtons.YesNo, MessageBoxIcon.Error)

        If QuitSelected = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub



    Private Sub btnCalcYear1_Click(sender As Object, e As EventArgs) Handles btnCalcYear1.Click

        'Clearing out the List box if the user wants to see Year 1-3 again on the same initial deposit & interest rate.
        lstOutYearly.Items.Clear()

        Dim GoodAmt As Boolean = Double.TryParse(txtDeposit.Text, DepositAmt)
        Dim GoodRate As Boolean = Double.TryParse(txtRate.Text, InterestRate)

        Dim Euro As Double = 0.9
        Dim Shekel As Double = 3.62
        Dim Yen As Double = 111.48
        Dim AUD As Double = 1.43
        Dim Pesos As Double = 19
        Dim Rubles As Double = 64.76
        Dim Pounds As Double = 0.77
        Dim Rupees As Double = 69.64

        Select Case SelectionChange

            Case 0
                DepositAmt = DepositAmt
            Case 1
                DepositAmt = DepositAmt * Euro
            Case 2
                DepositAmt = DepositAmt * Shekel
            Case 3
                DepositAmt = DepositAmt * Yen
            Case 4
                DepositAmt = DepositAmt * AUD
            Case 5
                DepositAmt = DepositAmt * Pesos
            Case 6
                DepositAmt = DepositAmt * Rubles
            Case 7
                DepositAmt = DepositAmt * Pounds
            Case 8
                DepositAmt = DepositAmt * Rupees

        End Select


        If GoodAmt AndAlso GoodRate Then

            InterestRate = InterestRate / 100
            InterestRateCalc = InterestRate * DepositAmt
            FinalYear1Amt = InterestRateCalc + DepositAmt

            If SelectionChange = 0 Then
                lstOutYearly.Items.Add("Your Balance after Year 1 is, " & FinalYear1Amt.ToString("c") & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 1 Then
                lstOutYearly.Items.Add("Your Balance after Year 1 is, " & FinalYear1Amt.ToString("n2") & " € " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 2 Then
                lstOutYearly.Items.Add("Your Balance after Year 1 is, " & FinalYear1Amt.ToString("N2") & " ₪ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 3 Then
                lstOutYearly.Items.Add("Your Balance after Year 1 is, " & FinalYear1Amt.ToString("n2") & " ¥ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 4 Then
                lstOutYearly.Items.Add("Your Balance after Year 1 is, " & FinalYear1Amt.ToString("n2") & " A$ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 5 Then
                lstOutYearly.Items.Add("Your Balance after Year 1 is, " & FinalYear1Amt.ToString("N2") & " M$ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 6 Then
                lstOutYearly.Items.Add("Your Balance after Year 1 is, " & FinalYear1Amt.ToString("N2") & " ₽ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 7 Then
                lstOutYearly.Items.Add("Your Balance after Year 1 is, " & FinalYear1Amt.ToString("N2") & " £ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 8 Then
                lstOutYearly.Items.Add("Your Balance after Year 1 is, " & FinalYear1Amt.ToString("N2") & " ₹ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            End If

            InterestRate = InterestRate 
            Year2Amt = FinalYear1Amt + (FinalYear1Amt * InterestRate)

            If SelectionChange = 0 Then
                lstOutYearly.Items.Add("Your Balance after Year 2 is, " & Year2Amt.ToString("c") & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 1 Then
                lstOutYearly.Items.Add("Your Balance after Year 2 is, " & Year2Amt.ToString("n2") & " € " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 2 Then
                lstOutYearly.Items.Add("Your Balance after Year 2 is, " & Year2Amt.ToString("N2") & " ₪ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 3 Then
                lstOutYearly.Items.Add("Your Balance after Year 2 is, " & Year2Amt.ToString("n2") & " ¥ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 4 Then
                lstOutYearly.Items.Add("Your Balance after Year 2 is, " & Year2Amt.ToString("n2") & " A$ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 5 Then
                lstOutYearly.Items.Add("Your Balance after Year 2 is, " & Year2Amt.ToString("N2") & " M$ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 6 Then
                lstOutYearly.Items.Add("Your Balance after Year 2 is, " & Year2Amt.ToString("N2") & " ₽ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 7 Then
                lstOutYearly.Items.Add("Your Balance after Year 2 is, " & Year2Amt.ToString("N2") & " £ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 8 Then
                lstOutYearly.Items.Add("Your Balance after Year 2 is, " & Year2Amt.ToString("N2") & " ₹ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            End If

            InterestRate = InterestRate
            Year3Amt = Year2Amt + (Year2Amt * InterestRate)

            If SelectionChange = 0 Then
                lstOutYearly.Items.Add("Your Balance after Year 3 is, " & Year3Amt.ToString("c") & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 1 Then
                lstOutYearly.Items.Add("Your Balance after Year 3 is, " & Year3Amt.ToString("n2") & " € " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 2 Then
                lstOutYearly.Items.Add("Your Balance after Year 3 is, " & Year3Amt.ToString("N2") & " ₪ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 3 Then
                lstOutYearly.Items.Add("Your Balance after Year 3 is, " & Year3Amt.ToString("n2") & " ¥ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 4 Then
                lstOutYearly.Items.Add("Your Balance after Year 3 is, " & Year3Amt.ToString("n2") & " A$ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 5 Then
                lstOutYearly.Items.Add("Your Balance after Year 3 is, " & Year3Amt.ToString("N2") & " M$ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 6 Then
                lstOutYearly.Items.Add("Your Balance after Year 3 is, " & Year3Amt.ToString("N2") & " ₽ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 7 Then
                lstOutYearly.Items.Add("Your Balance after Year 3 is, " & Year3Amt.ToString("N2") & " £ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 8 Then
                lstOutYearly.Items.Add("Your Balance after Year 3 is, " & Year3Amt.ToString("N2") & " ₹ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            End If

            btnCalcYear2.Enabled = True

        Else

            Dim CalcError1 As Integer
            CalcError1 = MessageBox.Show("You do not have a proper Initial Deposit & Interest Rate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnCalcYear2.Enabled = False

        End If

    End Sub

    Private Sub btnCalcYear2_Click(sender As Object, e As EventArgs) Handles btnCalcYear2.Click

        lstOutYearly.Items.Clear()

        Dim SecGoodAmt As Boolean = Double.TryParse(txtDeposit.Text, DepositAmt)
        Dim SecGoodRate As Boolean = Double.TryParse(txtRate.Text, InterestRate)

        If SecGoodAmt And SecGoodRate Then

            InterestRate = InterestRate / 100
            Year4Amt = Year3Amt + (Year3Amt * InterestRate)

            If SelectionChange = 0 Then
                lstOutYearly.Items.Add("Your Balance after Year 4 is, " & Year4Amt.ToString("c") & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 1 Then
                lstOutYearly.Items.Add("Your Balance after Year 4 is, " & Year4Amt.ToString("n2") & " € " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 2 Then
                lstOutYearly.Items.Add("Your Balance after Year 4 is, " & Year4Amt.ToString("N2") & " ₪ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 3 Then
                lstOutYearly.Items.Add("Your Balance after Year 4 is, " & Year4Amt.ToString("n2") & " ¥ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 4 Then
                lstOutYearly.Items.Add("Your Balance after Year 4 is, " & Year4Amt.ToString("n2") & " A$ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 5 Then
                lstOutYearly.Items.Add("Your Balance after Year 4 is, " & Year4Amt.ToString("N2") & " M$ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 6 Then
                lstOutYearly.Items.Add("Your Balance after Year 4 is, " & Year4Amt.ToString("N2") & " ₽ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 7 Then
                lstOutYearly.Items.Add("Your Balance after Year 4 is, " & Year4Amt.ToString("N2") & " £ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 8 Then
                lstOutYearly.Items.Add("Your Balance after Year 4 is, " & Year4Amt.ToString("N2") & " ₹ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            End If

            InterestRate = InterestRate
            Year5Amt = Year4Amt + (Year4Amt * InterestRate)

            If SelectionChange = 0 Then
                lstOutYearly.Items.Add("Your Balance after Year 5 is, " & Year5Amt.ToString("c") & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 1 Then
                lstOutYearly.Items.Add("Your Balance after Year 5 is, " & Year5Amt.ToString("n2") & " € " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 2 Then
                lstOutYearly.Items.Add("Your Balance after Year 5 is, " & Year5Amt.ToString("N2") & " ₪ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 3 Then
                lstOutYearly.Items.Add("Your Balance after Year 5 is, " & Year5Amt.ToString("n2") & " ¥ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 4 Then
                lstOutYearly.Items.Add("Your Balance after Year 5 is, " & Year5Amt.ToString("n2") & " A$ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 5 Then
                lstOutYearly.Items.Add("Your Balance after Year 5 is, " & Year5Amt.ToString("N2") & " M$ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 6 Then
                lstOutYearly.Items.Add("Your Balance after Year 5 is, " & Year5Amt.ToString("N2") & " ₽ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 7 Then
                lstOutYearly.Items.Add("Your Balance after Year 5 is, " & Year5Amt.ToString("N2") & " £ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 8 Then
                lstOutYearly.Items.Add("Your Balance after Year 5 is, " & Year5Amt.ToString("N2") & " ₹ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            End If

            InterestRate = InterestRate
            Year6Amt = Year5Amt + (Year5Amt * InterestRate)

            If SelectionChange = 0 Then
                lstOutYearly.Items.Add("Your Balance after Year 6 is, " & Year6Amt.ToString("c") & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 1 Then
                lstOutYearly.Items.Add("Your Balance after Year 6 is, " & Year6Amt.ToString("n2") & " € " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 2 Then
                lstOutYearly.Items.Add("Your Balance after Year 6 is, " & Year6Amt.ToString("N2") & " ₪ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 3 Then
                lstOutYearly.Items.Add("Your Balance after Year 6 is, " & Year6Amt.ToString("n2") & " ¥ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 4 Then
                lstOutYearly.Items.Add("Your Balance after Year 6 is, " & Year6Amt.ToString("n2") & " A$ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 5 Then
                lstOutYearly.Items.Add("Your Balance after Year 6 is, " & Year6Amt.ToString("N2") & " M$ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 6 Then
                lstOutYearly.Items.Add("Your Balance after Year 6 is, " & Year6Amt.ToString("N2") & " ₽ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 7 Then
                lstOutYearly.Items.Add("Your Balance after Year 6 is, " & Year6Amt.ToString("N2") & " £ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 8 Then
                lstOutYearly.Items.Add("Your Balance after Year 6 is, " & Year6Amt.ToString("N2") & " ₹ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            End If

            btnCalcYear1.Enabled = False
            btnCalcYear3.Enabled = True

        Else
            Dim CalcError2 As Integer
            CalcError2 = MessageBox.Show("You do not have a proper Initial Deposit & Interest Rate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnCalcYear3.Enabled = False



        End If

    End Sub

    Private Sub btnCalcYear3_Click(sender As Object, e As EventArgs) Handles btnCalcYear3.Click

        lstOutYearly.Items.Clear()

        Dim ThirdGoodAmt As Boolean = Double.TryParse(txtDeposit.Text, DepositAmt)
        Dim ThirdGoodRate As Boolean = Double.TryParse(txtRate.Text, InterestRate)

        If ThirdGoodAmt And ThirdGoodRate Then

            InterestRate = InterestRate / 100
            Year7Amt = Year6Amt + (Year6Amt * InterestRate)

            If SelectionChange = 0 Then
                lstOutYearly.Items.Add("Your Balance after Year 7 is, " & Year7Amt.ToString("c") & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 1 Then
                lstOutYearly.Items.Add("Your Balance after Year 7 is, " & Year7Amt.ToString("n2") & " € " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 2 Then
                lstOutYearly.Items.Add("Your Balance after Year 7 is, " & Year7Amt.ToString("N2") & " ₪ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 3 Then
                lstOutYearly.Items.Add("Your Balance after Year 7 is, " & Year7Amt.ToString("n2") & " ¥ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 4 Then
                lstOutYearly.Items.Add("Your Balance after Year 7 is, " & Year7Amt.ToString("n2") & " A$ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 5 Then
                lstOutYearly.Items.Add("Your Balance after Year 7 is, " & Year7Amt.ToString("N2") & " M$ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 6 Then
                lstOutYearly.Items.Add("Your Balance after Year 7 is, " & Year7Amt.ToString("N2") & " ₽ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 7 Then
                lstOutYearly.Items.Add("Your Balance after Year 7 is, " & Year7Amt.ToString("N2") & " £ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 8 Then
                lstOutYearly.Items.Add("Your Balance after Year 7 is, " & Year7Amt.ToString("N2") & " ₹ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            End If

            InterestRate = InterestRate
            Year8Amt = Year7Amt + (Year7Amt * InterestRate)

            If SelectionChange = 0 Then
                lstOutYearly.Items.Add("Your Balance after Year 8 is, " & Year8Amt.ToString("c") & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 1 Then
                lstOutYearly.Items.Add("Your Balance after Year 8 is, " & Year8Amt.ToString("n2") & " € " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 2 Then
                lstOutYearly.Items.Add("Your Balance after Year 8 is, " & Year8Amt.ToString("N2") & " ₪ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 3 Then
                lstOutYearly.Items.Add("Your Balance after Year 8 is, " & Year8Amt.ToString("n2") & " ¥ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 4 Then
                lstOutYearly.Items.Add("Your Balance after Year 8 is, " & Year8Amt.ToString("n2") & " A$ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 5 Then
                lstOutYearly.Items.Add("Your Balance after Year 8 is, " & Year8Amt.ToString("N2") & " M$ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 6 Then
                lstOutYearly.Items.Add("Your Balance after Year 8 is, " & Year8Amt.ToString("N2") & " ₽ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 7 Then
                lstOutYearly.Items.Add("Your Balance after Year 8 is, " & Year8Amt.ToString("N2") & " £ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 8 Then
                lstOutYearly.Items.Add("Your Balance after Year 8 is, " & Year8Amt.ToString("N2") & " ₹ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            End If

            InterestRate = InterestRate
            Year9Amt = Year8Amt + (Year8Amt * InterestRate)

            If SelectionChange = 0 Then
                lstOutYearly.Items.Add("Your Balance after Year 9 is, " & Year9Amt.ToString("c") & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 1 Then
                lstOutYearly.Items.Add("Your Balance after Year 9 is, " & Year9Amt.ToString("n2") & " € " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 2 Then
                lstOutYearly.Items.Add("Your Balance after Year 9 is, " & Year9Amt.ToString("N2") & " ₪ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 3 Then
                lstOutYearly.Items.Add("Your Balance after Year 9 is, " & Year9Amt.ToString("n2") & " ¥ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 4 Then
                lstOutYearly.Items.Add("Your Balance after Year 9 is, " & Year9Amt.ToString("n2") & " A$ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 5 Then
                lstOutYearly.Items.Add("Your Balance after Year 9 is, " & Year9Amt.ToString("N2") & " M$ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 6 Then
                lstOutYearly.Items.Add("Your Balance after Year 9 is, " & Year9Amt.ToString("N2") & " ₽ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 7 Then
                lstOutYearly.Items.Add("Your Balance after Year 9 is, " & Year9Amt.ToString("N2") & " £ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 8 Then
                lstOutYearly.Items.Add("Your Balance after Year 9 is, " & Year9Amt.ToString("N2") & " ₹ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            End If

            InterestRate = InterestRate
            Year10Amt = Year9Amt + (Year9Amt * InterestRate)

            If SelectionChange = 0 Then
                lstOutYearly.Items.Add("Your Balance after Year 10 is, " & Year10Amt.ToString("c") & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 1 Then
                lstOutYearly.Items.Add("Your Balance after Year 10 is, " & Year10Amt.ToString("n2") & " € " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 2 Then
                lstOutYearly.Items.Add("Your Balance after Year 10 is, " & Year10Amt.ToString("N2") & " ₪ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 3 Then
                lstOutYearly.Items.Add("Your Balance after Year 10 is, " & Year10Amt.ToString("n2") & " ¥ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 4 Then
                lstOutYearly.Items.Add("Your Balance after Year 10 is, " & Year10Amt.ToString("n2") & " A$ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 5 Then
                lstOutYearly.Items.Add("Your Balance after Year 10 is, " & Year10Amt.ToString("N2") & " M$ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 6 Then
                lstOutYearly.Items.Add("Your Balance after Year 10 is, " & Year10Amt.ToString("N2") & " ₽ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 7 Then
                lstOutYearly.Items.Add("Your Balance after Year 10 is, " & Year10Amt.ToString("N2") & " £ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            ElseIf SelectionChange = 8 Then
                lstOutYearly.Items.Add("Your Balance after Year 10 is, " & Year10Amt.ToString("N2") & " ₹ " & " from an Interest Rate of " & InterestRate.ToString("p"))
            End If

        Else
            Dim CalcError3 As Integer
            CalcError3 = MessageBox.Show("You do not have a proper Initial Deposit & Interest Rate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        btnCalcYear1.Enabled = True
        btnCalcYear2.Enabled = False
        btnCalcYear3.Enabled = False

    End Sub


End Class
