Public Class Form1
    Dim a, b, c, d As Integer
    Dim suma1, suma2, suma3, suma4 As Integer

    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click
        a = Val(a1.Text)
        b = Val(a2.Text)
        c = Val(a3.Text)
        d = Val(a4.Text)

        suma1 = a
        suma2 = b
        suma3 = c
        suma4 = d

        a = Val(b1.Text)
        b = Val(b2.Text)
        c = Val(b3.Text)
        d = Val(b4.Text)

        sa1.Text = Val(suma1) + (a)
        sa2.Text = Val(suma2) + (b)
        sa3.Text = Val(suma3) + (c)
        sa4.Text = Val(suma4) + (d)

        sb1.Text = Val(suma1) - (a)
        sb2.Text = Val(suma2) - (b)
        sb3.Text = Val(suma3) - (c)
        sb4.Text = Val(suma4) - (d)
    End Sub
End Class
