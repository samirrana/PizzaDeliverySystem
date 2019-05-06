Public Class Form1
    Dim Invalid As Boolean = False

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtname.TextChanged
        If IsNumeric(txtname.Text) Then
            MsgBox("Please key in alphabets")

            txtname.Clear()


        End If
    End Sub

    Private Sub txtphonenumber_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtphonenumber.TextChanged


        If IsNumeric(txtphonenumber.Text) = False Then
            MsgBox("Please key in numbers")
            txtphonenumber.Text = ""
            txtphonenumber.Focus()




        End If


    End Sub

    Private Sub txtpostalcode_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtpostalcode.TextChanged
        'If Not IsNumeric(txtpostalcode.Text) Then
        'MsgBox("Please key in a number")

        'End If

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        txtname.Clear()
        txtphonenumber.Clear()
        txtpostalcode.Clear()
        txtemailaddress.Clear()
        ComboBox1.Items.Clear()
        txtpostalcode.Clear()
        txtaddress.Clear()




    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtemailaddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtemailaddress.TextChanged

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub txtaddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtaddress.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As System.Object, e As System.EventArgs)

    End Sub
End Class