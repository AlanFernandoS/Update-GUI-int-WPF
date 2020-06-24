Imports System.Timers
Imports System.Windows.Threading
Class MainWindow
    WithEvents MyTimmer As New System.Timers.Timer With {.AutoReset = True, .Enabled = False, .Interval = 500}
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        If MyTimmer.Enabled Then
            MyTimmer.Stop()
            RunButton.Content = "Iniciar"
        Else
            MyTimmer.Start()
            RunButton.Content = "Detener"
        End If
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub MyTimmer_Elapsed(sender As Object, e As ElapsedEventArgs) Handles MyTimmer.Elapsed
        Dispatcher.Invoke(Sub()
                              RegisterLog.Text = RegisterLog.Text + vbNewLine + " Ha pasado el tiempo"
                          End Sub)
    End Sub
End Class
