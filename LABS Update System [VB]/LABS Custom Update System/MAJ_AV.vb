Imports System.Net

Public Class MAJ_AV
    Private Sub MAJ_AV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim MAJ As New WebClient
        Dim Four As New WebClient
        Dim derniereVersion As String = MAJ.DownloadString("https://dl.dropboxusercontent.com/s/fq422itj45dszky/version.txt") 'dernier version du logiciel
        Dim FourMaj As String = Four.DownloadString("https://dl.dropboxusercontent.com/s/hwh2sldew5nhr07/fournisseur%20de%20la%20mise%20%C3%A0%20jour.txt") ' fournisseur de la mise à jour
        Label2.Text = "Version : " + derniereVersion
        Label3.Text = "Fournisseur : " + FourMaj

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MAJ2 As New WebClient
        Dim downloadLink As String = MAJ2.DownloadString("https://dl.dropboxusercontent.com/s/qqs546lbhowi2u3/download.txt") 'lien du logiciel à télécharger
        Process.Start(downloadLink)
    End Sub
End Class