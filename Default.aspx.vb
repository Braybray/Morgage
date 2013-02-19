
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub TextBox3_TextChanged(sender As Object, e As System.EventArgs) Handles MorgageLength.TextChanged

    End Sub

    Protected Sub PerformCalcButton_Click(sender As Object, e As System.EventArgs) Handles PerformCalcButton.Click

        'Specify constant values
        Const INTEREST_CALCS_PER_YEAR As Integer = 12
        Const PAYMENTS_PER_YEAR As Integer = 12

        'Create variable to hold the values entered by the users
        Dim P As Decimal = LoanAmount.Text
        Dim r As Decimal = Rate.Text / 100
        Dim t As Decimal = MorgageLength.Text

        Dim ratePerperiod As Decimal
        ratePerperiod = r / INTEREST_CALCS_PER_YEAR

        Dim PayPeriods As Integer
        PayPeriods = t * PAYMENTS_PER_YEAR

        Dim annualRate As Decimal
        annualRate = Math.Exp(INTEREST_CALCS_PER_YEAR * Math.Log(1 + ratePerperiod)) - 1

        Dim intPerPayment As Decimal
        intPerPayment = (Math.Exp(Math.Log(annualRate + 1) / PayPeriods) - 1) * PayPeriods
        'nOW COMPUTE THE TOTAL COST OF THE LOAN

        Dim intPerMonth As Decimal = intPerPayment / PAYMENTS_PER_YEAR

        Dim costPerMonth As Decimal
        costPerMonth = P * intPerMonth / (1 - Math.Pow(intPerMonth + 1, -PayPeriods))

        'Display the results in the results label web Control
        Results.Text = "Your morgage payment per month is $" & costPerMonth.ToString("#,####.##")









    End Sub
End Class
