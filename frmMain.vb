Imports System.IO
Imports System.Xml

Public Class frmMain

    Private Sub btnGetWeather_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetWeather.Click

        Dim stream As XmlReader = XmlReader.Create("http://weather.yahooapis.com/forecastrss?p=USPA0031&amp;u=f")
        Dim blnWeather As Boolean
        Dim strtemp As String

        blnWeather = stream.ReadToFollowing("yweather:condition")
        strtemp = stream.GetAttribute("temp")
        MessageBox.Show("The current temp is:  " & strtemp)

    End Sub
End Class
