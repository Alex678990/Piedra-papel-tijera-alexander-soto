Public Class Form1

    Dim rachapartidas As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play("C:\Users\Hp\Downloads\Solo Leveling - Opening FULL LEveL by SawanoHiroyuki[nZk]_TOMORROW X TOGETHER (Lyrics).wav", AudioPlayMode.BackgroundLoop)
    End Sub
    Private Enum opciones
        piedra
        papel
        tijera
    End Enum

    Private Function determinarganador(jugador As opciones, computadora As opciones) As String
        If jugador = computadora Then
            Return "Empate."
        ElseIf (jugador = opciones.piedra AndAlso computadora = opciones.tijera) OrElse
                (jugador = opciones.papel AndAlso computadora = opciones.piedra) OrElse
                (jugador = opciones.tijera AndAlso computadora = opciones.papel) Then
            rachapartidas += 1
            lbl_rachadevictorias.Text = rachapartidas
            Return "Ganaste!"


        Else
            rachapartidas = 0
            lbl_rachadevictorias.Text = 0
            Return "Ganan los Monarcas..."

        End If
    End Function

    Private Function monarcas() As opciones
        Dim rand As New Random()
        Return CType(rand.Next(0, 3), opciones)
    End Function

    Private Sub jugar(opcionJugador As opciones)
        Dim opcioncomp As opciones = monarcas()
        lbl_resultado.Text = (determinarganador(opcionJugador, opcioncomp))
    End Sub
    Private Sub btn_piedra_Click(sender As Object, e As EventArgs) Handles btn_piedra.Click
        jugar(opciones.piedra)
    End Sub

    Private Sub btn_papel_Click(sender As Object, e As EventArgs) Handles btn_papel.Click
        jugar(opciones.papel)
    End Sub

    Private Sub btn_tijera_Click(sender As Object, e As EventArgs) Handles btn_tijera.Click
        jugar(opciones.tijera)
    End Sub


End Class
