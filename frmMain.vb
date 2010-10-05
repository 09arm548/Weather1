Imports System.IO
Imports System.Xml

Public Class frmMain



    Private Sub btnGetWeather_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetWeather.Click

        Dim stream As XmlReader = XmlReader.Create("http://weather.yahooapis.com/forecastrss?p=USPA0031&amp;u=f")
        Dim anything As Boolean
        Dim temp As String


        Do Until anything = True
            anything = stream.ReadToFollowing("yweather:condition")
        Loop
        temp = stream.GetAttribute("temp")



        MessageBox.Show(temp)



    End Sub
End Class
