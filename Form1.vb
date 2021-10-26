Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'devinir variable
        Dim Fecha As Date
        Dim mensajeas String
        'Definiendo la variable
        Fecha = Date.Now
        mensajeas = "Trabajo de Yzai Alarcon Franca"
        'Mostrar en 
        lbmjs.Text = mensajeas
        lbfecha.Text = Fecha
    End Sub

    Private Sub suma_Click(sender As Object, e As EventArgs) Handles suma.Click
        'Nombrar una variable entero 
        Dim sumanum1 As Integer
        Dim sumanum2 As Integer
        Dim sumares As Integer

        'Nombrar las variables con las funciones del diseño
        sumanum1 = txtnumero1.Text
        sumanum2 = txtnumero2.Text

        'Llamar las variables para hacer la operacion
        sumares = sumanum1 + sumanum2

        txtresultado.Text = sumares
    End Sub

    Private Sub Resta_Click(sender As Object, e As EventArgs) Handles Resta.Click
        'Nombrar una variable entero 
        Dim num1 As Integer
        Dim num2 As Integer
        Dim res As Integer

        'Nombrar las variables con las funciones del diseño
        num1 = txtnumero1.Text
        num2 = txtnumero2.Text

        'Llamar las variables para hacer la operacion
        res = num1 - num2

        txtresultado.Text = res
    End Sub

    Private Sub Multiplicar_Click(sender As Object, e As EventArgs) Handles Multiplicar.Click
        'Nombrar una variable entero 
        Dim multinum1 As Integer
        Dim multinum2 As Integer
        Dim multires As Integer

        'Nombrar las variables con las funciones del diseño
        multinum1 = txtnumero1.Text
        multinum2 = txtnumero2.Text

        'Llamar las variables para hacer la operacion
        multires = multinum1 * multinum2

        txtresultado.Text = multires
    End Sub

    Private Sub dividir_Click(sender As Object, e As EventArgs) Handles dividir.Click
        'Nombrar una variable con punto decimal 
        Dim divnum1 As Double
        Dim divnum2 As Double
        Dim divres As Double

        'Nombrar las variables con las funciones del diseño
        divnum1 = txtnumero1.Text
        divnum2 = txtnumero2.Text

        'Llamar las variables para hacer la operacion
        divres = divnum1 / divnum2

        txtresultado.Text = divres
    End Sub

End Class
