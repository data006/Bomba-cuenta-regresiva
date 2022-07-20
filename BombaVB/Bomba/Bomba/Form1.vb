Public Class frmBombaVB


    Dim desactivada As Boolean = False
    Dim explocion As Boolean = False
    Dim contador As Integer = 0

    'Iniciar forma
    Private Sub frmBombaVB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        My.Computer.Audio.Play(My.Resources.rola, AudioPlayMode.BackgroundLoop)
        lblMilis.Text = "00"
        lblSegundos.Text = "00"
        lblMinutos.Text = "02"


    End Sub




    Private Sub tmrTiempo_Tick(sender As Object, e As EventArgs) Handles tmrTiempo.Tick



        If desactivada = False Then

            If ((lblMinutos.Text <= 0 And lblSegundos.Text <= 1 And lblMilis.Text <= 10)) Then

                lblMinutos.Text = "00"
                lblSegundos.Text = "00"
                lblMilis.Text = "00"
                desactivada = True
            ElseIf desactivada = False Then

                Restar()
            End If

        Else

            pbxBomba.Image = My.Resources.bojiman
            pbxBomba.Image = My.Resources.bojiman

        End If



        If contador = 1 Then

            pbxBomba.Image = My.Resources._1

        ElseIf contador = 5 Then

            pbxBomba.Image = My.Resources._2


        ElseIf contador = 9 Then
            pbxBomba.Image = My.Resources._3


        ElseIf contador = 13 Then

            pbxBomba.Image = My.Resources._4
        ElseIf contador = 17 Then

            pbxBomba.Image = My.Resources._5
        ElseIf contador = 21 Then

            pbxBomba.Image = My.Resources._6
        ElseIf contador = 25 Then

            pbxBomba.Image = My.Resources._7
        ElseIf contador = 29 Then

            pbxBomba.Image = My.Resources._8
        ElseIf contador = 33 Then

            pbxBomba.Image = My.Resources._9
        ElseIf contador = 37 Then

            pbxBomba.Image = My.Resources._10
        ElseIf contador = 41 Then

            pbxBomba.Image = My.Resources._11
        ElseIf contador = 45 Then

            pbxBomba.Image = My.Resources._12
        ElseIf contador = 49 Then

            pbxBomba.Image = My.Resources._13
        ElseIf contador = 53 Then

            pbxBomba.Image = My.Resources._14
        ElseIf contador = 57 Then

            pbxBomba.Image = My.Resources._15
        ElseIf contador = 61 Then

            pbxBomba.Image = My.Resources._16
        ElseIf contador = 65 Then

            pbxBomba.Image = My.Resources._17
        ElseIf contador = 69 Then

            pbxBomba.Image = My.Resources._18
        ElseIf contador = 73 Then

            pbxBomba.Image = My.Resources._19
        ElseIf contador = 77 Then

            pbxBomba.Image = My.Resources._20
        ElseIf contador = 81 Then

            pbxBomba.Image = My.Resources._21
        ElseIf contador = 85 Then

            pbxBomba.Image = My.Resources._22
        ElseIf contador = 89 Then

            pbxBomba.Image = My.Resources._23
        ElseIf contador = 93 Then

            pbxBomba.Image = My.Resources._24
        ElseIf contador = 97 Then

            pbxBomba.Image = My.Resources._25
        ElseIf contador = 101 Then

            pbxBomba.Image = My.Resources._26
        ElseIf contador = 105 Then

            pbxBomba.Image = My.Resources._27
        ElseIf contador = 109 Then

            pbxBomba.Image = My.Resources._28
        ElseIf contador = 113 Then

            pbxBomba.Image = My.Resources._29
        ElseIf contador = 117 Then

            pbxBomba.Image = My.Resources._30
        ElseIf contador >= 118 Then

            tmrTiempo.Enabled = False
            pbxBomba.Image = My.Resources.explosion
            lblMilis.Text = "00"
            lblMinutos.Text = "00"
            lblSegundos.Text = "00"
            If explocion = False Then

                My.Computer.Audio.Play(My.Resources.audio, AudioPlayMode.Background)
                explocion = True

            End If



        End If



    End Sub








    Sub Restar()








        If (lblMilis.Text <= 0) Then

            lblSegundos.Text = lblSegundos.Text - 1
            contador = contador + 1

            If (lblSegundos.Text <= 0) Then

                lblMinutos.Text = lblMinutos.Text - 1

                lblSegundos.Text = 59

                If (lblMinutos.Text <= 0) Then

                    lblMinutos.Text = 0

                End If

            End If

            lblMilis.Text = 90

        Else

            lblMilis.Text = lblMilis.Text - 10

        End If



        If lblMilis.Text <= 0 Then

            lblMilis.Text = "00"

        End If

        If lblSegundos.Text.Length < 2 Then

            lblSegundos.Text = "0" & lblSegundos.Text



        End If

        If lblMinutos.Text.Length < 2 Then

            lblMinutos.Text = "0" & lblMinutos.Text



        End If

    End Sub










    Private Sub btnRojo_Click(sender As Object, e As EventArgs) Handles btnRojo.Click
        If contador < 118 Then



            If (txtPass.Text Like "hola") Then

                If desactivada = False Then

                    desactivada = True
                    pbxBomba.Image = My.Resources.bojiman

                    MsgBox("Bomba desactivada")

                End If



            Else

                MsgBox("Password incorrecta")



            End If
        End If

    End Sub

    Private Sub btnAzul_Click(sender As Object, e As EventArgs) Handles btnAzul.Click
        If contador < 118 Then


            If (txtPass.Text Like "hola") Then

                If desactivada = False Then

                    desactivada = True
                    pbxBomba.Image = My.Resources.bojiman

                    MsgBox("Bomba desactivada")

                End If




            Else

                MsgBox("Password incorrecta")

            End If
            End If

    End Sub
End Class
