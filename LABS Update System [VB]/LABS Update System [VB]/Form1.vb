Imports System.Net

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        checkUpdateAV() 'éxecuter la fonction
    End Sub
    Sub checkUpdateAV()
        Dim MAJ As New WebClient
        Dim Four As New WebClient
        Dim versionActuelle As String = "1.0"  'version du logiciel actuelle
        Dim derniereVersion As String = MAJ.DownloadString("https://dl.dropboxusercontent.com/s/fq422itj45dszky/version.txt") 'dernier version du logiciel
        Dim FourMaj As String = Four.DownloadString("https://dl.dropboxusercontent.com/s/hwh2sldew5nhr07/fournisseur%20de%20la%20mise%20%C3%A0%20jour.txt") ' fournisseur de la mise à jour
        If versionActuelle = derniereVersion Then
            MsgBox("Tout est à jour !")
        Else
            MsgBox("Des mises à jour sont disponibles." & vbNewLine & "La dernière version est : " & derniereVersion & vbNewLine & "Fournit par : " & FourMaj, vbOKOnly + MsgBoxStyle.Information, "Mise à jour du logiciel")
            Dim MAJ2 As New WebClient
            Dim downloadLink As String = MAJ2.DownloadString("https://dl.dropboxusercontent.com/s/qqs546lbhowi2u3/download.txt") 'lien du logiciel à télécharger
            Process.Start(downloadLink) 'ouvre le lien dans le navigateur
        End If
    End Sub
    Sub checkUpdateUn()
        Dim MAJ As New WebClient
        Dim Four As New WebClient
        Dim versionActuelle As String = "1.0"  'version du logiciel actuelle
        Dim derniereVersion As String = MAJ.DownloadString("https://dl.dropboxusercontent.com/s/ftrj49vyiab1otr/version2.txt") 'dernier version du logiciel
        Dim FourMaj As String = Four.DownloadString("https://dl.dropboxusercontent.com/s/hwh2sldew5nhr07/fournisseur%20de%20la%20mise%20%C3%A0%20jour.txt") ' fournisseur de la mise à jour
        If versionActuelle = derniereVersion Then
            MsgBox("Tout est à jour !")
        Else
            MsgBox("Des mises à jour sont disponibles." & vbNewLine & "La dernière version est : " & derniereVersion & vbNewLine & "Fournit par : " & FourMaj, vbOKOnly + MsgBoxStyle.Information, "Mise à jour du logiciel")
            Dim MAJ2 As New WebClient
            Dim downloadLink As String = MAJ2.DownloadString("https://dl.dropboxusercontent.com/s/qqs546lbhowi2u3/download.txt") 'lien du logiciel à télécharger
            Process.Start(downloadLink) 'ouvre le lien dans le navigateur
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        checkUpdateUn() 'éxecuter la fonction
    End Sub
End Class
