'Sams Teach Yourself ASP.NET 3.5 in 24 Hours
'Scott Michell         
'Copyright 2008 by Pearson Education Inc. 
'p.90

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub performCalculateButton_Click(sender As Object, e As System.EventArgs) Handles performCalculateButton.Click

        'specify constant values
        Const INTEREST_CALCS_PER_YEAR As Integer = 12
        Const PAYMENTS_PER_YEAR As Integer = 12

        'Create variables to hold the values entered by the user 
        Dim P As Decimal = loanamount.Text
        Dim r As Decimal = rate.Text / 100
        Dim t As Decimal = mortgagelength.Text

        Dim ratePerPeriod As Decimal
        ratePerPeriod = r / INTEREST_CALCS_PER_YEAR

        Dim payPeriods = t * PAYMENTS_PER_YEAR

        Dim annualRate As Decimal
        annualRate = Math.Exp(INTEREST_CALCS_PER_YEAR * Math.Log(1 + ratePerPeriod)) - 1

        Dim intPerpayment As Decimal
        intPerpayment = Math.Exp(Math.Log(annualRate + 1) / payPeriods) * payPeriods

        'Now compute the total cost of the loan
        Dim intPerMonth As Decimal = intPerpayment / PAYMENTS_PER_YEAR

        Dim costPerMonth As Decimal
        costPerMonth = P * intPerMonth / (1 - Math.Pow(intPerMonth + 1, -payPeriods))

        'display the results int eh results label Web Control 
        Results.Text = "Your mortgage payment per month is $" & costPerMonth.ToString("#,####.##")

    End Sub
End Class












