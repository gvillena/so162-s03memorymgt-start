Imports System.Text

Public Class ParticionFija

#Region " Fields "

    ' Administrador de Memoria en Ejecucion
    Private Ejecucion As Boolean = False

    ' Lista de Procesos 
    Private ListaProcesos As List(Of Proceso)

    ' Lista de Particiones
    Private ListaParticiones As List(Of Particion)

    ' Lista de Particiones Libres
    Private ParticionesLibres As List(Of Particion)

    ' Lista de Particiones Ocupadas
    Private ParticionesOcupadas As List(Of Particion)

#End Region

#Region " Inicializacion "

    Public Sub Inicializar(_tamañoMemoria As Integer, _listaParticiones As List(Of Particion))
        ' TODO
    End Sub

#End Region

#Region " Subs & Functions"

    Private Sub AsignarEspacio()
        ' TODO
    End Sub

    Private Function BuscarParticionLibre(tamañoProceso As Integer) As Integer
        ' TODO
        Return 0
    End Function

    Private Sub ActualizarDgvParticiones()
        ' TODO
    End Sub

    Private Sub ActualizaDgvProcesos()
        ' TODO
    End Sub

#End Region

#Region " Windows Forms Events "

    Private Sub ParticionFija_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' TODO
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        ' TODO
    End Sub

    Private Sub btnAgregarProceso_Click(sender As Object, e As EventArgs) Handles btnAgregarProceso.Click
        ' TODO
    End Sub

    Private Sub btnTerminarProceso_Click(sender As Object, e As EventArgs) Handles btnTerminarProceso.Click
        ' TODO
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        ' TODO
    End Sub

#End Region

End Class