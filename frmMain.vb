Imports System.IO
Imports System.Xml

Public Class frmMain


    Private Sub btnGetWeather_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetWeather.Click
        '''I NEED TO:
        ''' CREATE A XML READER
        ''' FIGURE OUT HOW TO READ XML
        ''' AND LOOP THRU TO FIND THE WEATHER

        'Dim stream As System.IO.StreamReader = New StreamReader("www.weather.com")

        'MessageBox.Show(stream.ReadLine)
        ' Loads the XML data in the file books.xml in a new stream.
        'stream = New StreamReader("http://weather.yahooapis.com/forecastrss?w=2502265")

        'ListBox1.Items.Add(stream)


        Dim rssURL As String = "http://weather.yahooapis.com/forecastrss?w=2502265"
        Dim myRequest As System.Net.WebRequest = System.Net.WebRequest.Create(rssURL)
        'ListBox1.Items.Add(rssURL)
        'Dim myResponse As System.Net.WebResponse = myRequest.GetResponse
        'Dim rssStream As System.IO.Stream = myResponse.GetResponseStream()
        'Dim rssDoc As System.Xml.XmlDocument = New System.Xml.XmlDocument()
        'rssDoc.Load(rssStream)
        ' Dim rssItems As System.Xml.XmlNodeList = rssDoc.SelectNodes
        'figure out 3 calls to get weather ' 3 method calls from the xml reader call
        'github to work 
    End Sub
End Class
