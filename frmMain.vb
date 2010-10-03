Imports System.IO
Imports System.Xml

Public Class frmMain


    Private Sub btnGetWeather_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetWeather.Click
        'txtWOEID.Text = "www.weather.yahoo.com" 'apis.com" '/forecastrss?w=2502265"
        'WebBrowser1.Navigate(txtWOEID.Text)
        'Dim streamreader As System.IO.StringReader
        'streamreader = New StringReader("www.weather.com")
        'Dim reader As XmlTextReader = New XmlTextReader(Stream)
        Const URLString As String = "http://www.weather.com"
        Dim reader As XmlTextReader = New XmlTextReader(URLString)
        Console.Write("<" + reader.Name)
        Console.WriteLine(">")
        ListBox1.Items.Add(URLString)
        'figure out 3 calls to get weather ' 3 method calls from the xml reader call
        'github to work 
    End Sub
End Class
