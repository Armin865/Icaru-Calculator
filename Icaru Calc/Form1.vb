Public Class Form1

    Private this As Object

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Guardset As Double
        Dim Start As Double
        Start = 736

        If ComboBox2.SelectedItem Then

        End If







    End Sub



    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "0" Then
            TextBox13.Text = "+0"
        ElseIf ComboBox2.Text = "1" Then
            TextBox13.Text = "+111"
        ElseIf ComboBox2.Text = "2" Then
            TextBox13.Text = "+221"
        ElseIf ComboBox2.Text = "3" Then
            TextBox13.Text = "+332"

        End If




    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.Text = "0" Then
            TextBox14.Text = "+0"
        ElseIf ComboBox3.Text = "1" Then
            TextBox14.Text = "+59"
        ElseIf ComboBox3.Text = "2" Then
            TextBox14.Text = "+118"
        ElseIf ComboBox3.Text = "3" Then
            TextBox14.Text = "+177"
        ElseIf ComboBox3.Text = "4" Then
            TextBox14.Text = "+236"
        ElseIf ComboBox3.Text = "5" Then
            TextBox14.Text = "+295"
        ElseIf ComboBox3.Text = "6" Then
            TextBox14.Text = "+354"
        ElseIf ComboBox3.Text = "7" Then
            TextBox14.Text = "+413"
        ElseIf ComboBox3.Text = "8" Then
            TextBox14.Text = "+472"
        ElseIf ComboBox3.Text = "9" Then
            TextBox14.Text = "+530"
        ElseIf ComboBox3.Text = "10" Then
            TextBox14.Text = "+589"
        ElseIf ComboBox3.Text = "11" Then
            TextBox14.Text = "+648"
        ElseIf ComboBox3.Text = "12" Then
            TextBox14.Text = "+707"






        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "0" Then
            TextBox15.Text = "+0"
        ElseIf ComboBox1.Text = "1" Then
            TextBox15.Text = "+15"
        ElseIf ComboBox1.Text = "2" Then
            TextBox15.Text = "+30"
        ElseIf ComboBox1.Text = "3" Then
            TextBox15.Text = "+45"
        ElseIf ComboBox1.Text = "4" Then
            TextBox15.Text = "+59"
        ElseIf ComboBox1.Text = "5" Then
            TextBox15.Text = "+74"
        ElseIf ComboBox1.Text = "6" Then
            TextBox15.Text = "+89"
        ElseIf ComboBox1.Text = "7" Then
            TextBox15.Text = "+104"
        ElseIf ComboBox1.Text = "8" Then
            TextBox15.Text = "+118"
        ElseIf ComboBox1.Text = "9" Then
            TextBox15.Text = "+133"
        ElseIf ComboBox1.Text = "10" Then
            TextBox15.Text = "+148"
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        If ComboBox4.Text = "0" Then
            TextBox16.Text = "+0"
        ElseIf ComboBox4.Text = "2" Then
            TextBox16.Text = "+15"
        ElseIf ComboBox4.Text = "5" Then
            TextBox16.Text = "+37"
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Double
        Dim num2 As Double
        Dim num3 As Double
        Dim num4 As Double
        Dim num5 As Double
        num1 = Convert.ToDouble(TextBox13.Text)
        num2 = Convert.ToDouble(TextBox14.Text)
        num3 = Convert.ToDouble(TextBox15.Text)
        num4 = Convert.ToDouble(TextBox16.Text)
        num5 = num1 + num2 + num3 + num4
        TextBox17.Text = CStr(num5)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim def1 As Double

        def1 = Convert.ToDouble(TextBox1.Text)
        TextBox19.Text = (def1 / 100) * 736

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim def2 As Double

        def2 = Convert.ToDouble(TextBox2.Text)
        TextBox18.Text = def2
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim def3 As Double

        def3 = Convert.ToDouble(TextBox3.Text)
        TextBox20.Text = def3
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Dim def4 As Double

        def4 = Convert.ToDouble(TextBox4.Text)
        TextBox21.Text = (def4 / 100) * 736
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        Dim def5 As Double

        def5 = Convert.ToDouble(TextBox5.Text)
        TextBox22.Text = (def5 / 100) * 736
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Dim def6 As Double

        def6 = Convert.ToDouble(TextBox6.Text)
        TextBox23.Text = def6
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        Dim def7 As Double

        def7 = Convert.ToDouble(TextBox7.Text)
        TextBox24.Text = (def7 / 100) * 736
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        Dim def8 As Double

        def8 = Convert.ToDouble(TextBox8.Text)
        TextBox25.Text = def8
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        Dim def9 As Double

        def9 = Convert.ToDouble(TextBox9.Text)
        TextBox26.Text = (def9 / 100) * 736
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        Dim def10 As Double

        def10 = Convert.ToDouble(TextBox10.Text)
        TextBox27.Text = def10
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim def11 As Double
        Dim def12 As Double

        def12 = Convert.ToDouble(TextBox19.Text)
        Dim def13 As Double

        def13 = Convert.ToDouble(TextBox18.Text)
        Dim def14 As Double

        def14 = Convert.ToDouble(TextBox20.Text)
        Dim def15 As Double

        def15 = Convert.ToDouble(TextBox21.Text)
        Dim def16 As Double

        def16 = Convert.ToDouble(TextBox22.Text)
        Dim def17 As Double

        def17 = Convert.ToDouble(TextBox23.Text)
        Dim def18 As Double

        def18 = Convert.ToDouble(TextBox24.Text)
        Dim def19 As Double

        def19 = Convert.ToDouble(TextBox25.Text)
        Dim def20 As Double

        def20 = Convert.ToDouble(TextBox26.Text)
        Dim def21 As Double

        def21 = Convert.ToDouble(TextBox27.Text)
        def11 = def12 + def13 + def14 + def15 + def16 + def17 + def18 + def19 + def20 + def21
        TextBox28.Text = CStr(def11)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num11 As Double
        num11 = Convert.ToDouble(TextBox11.Text)
        TextBox29.Text = num11
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim final1 As Double
        Dim final2 As Double
        Dim final3 As Double
        Dim final4 As Double
        Dim final5 As Double
        Dim final6 As Double
        final1 = Convert.ToDouble(TextBox12.Text)
        final2 = Convert.ToDouble(TextBox17.Text)
        final3 = Convert.ToDouble(TextBox28.Text)
        final4 = Convert.ToDouble(TextBox29.Text)
        final6 = Convert.ToDouble(TextBox13.Text)
        final5 = final1 + final2 + final3 + final4
        TextBox31.Text = Math.Ceiling(final3 + final4 + final6)
        TextBox30.Text = Math.Ceiling(final5)
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click


    End Sub
End Class
