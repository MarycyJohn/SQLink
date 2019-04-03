#|--------------------------------------|
#|Author: Maurycy Graclik               |
#|maurycy.graclik@student.put.poznan.pl |
#|Date: 17/03/19                        |
#|--------------------------------------|

$temp_path_main = "C:\temp_SQLink" #temp main path
$temp_path_logs = "C:\temp_SQLink\temp_logs" #temp log path
$result_zip="C:\temp_SQLink\${env:COMPUTERNAME}_logs.zip" #destiunation zip
$print_date=get-date -f hh_mm-dd.MM.yy
$localisation="C:\temp_SQLink\temp_logs\${env:COMPUTERNAME}_logs_from_$($print_date)_in_behalf_of_user_$($env:UserName).txt" #extracted files
$logged_hours = 3 #number of hours to collect
#Set-ExecutionPolicy -ExecutionPolicy RemoteSigned
$recipient = "maurycy.graclik@student.put.poznan.pl"
$now=get-date

Set-Variable -Name EventTypes -Value @("Error", "Warning") # type of listed logs

#Create temp folders
Remove-Item $temp_path_main -Recurse -ErrorAction Ignore  
md -Force $temp_path_main | Out-Null
Start-Sleep -s 1
md -Force $temp_path_logs | Out-Null

#get data
Get-EventLog -LogName System -EntryType $EventTypes -After ($now).AddHours(-$logged_hours) |Format-Table -wrap -auto| Out-File -FilePath $localisation -append # Log systemowy
Get-EventLog -LogName Application -EntryType $EventTypes -After ($now).AddHours(-$logged_hours) |Format-Table -wrap -auto| Out-File -FilePath $localisation -append # Log Aplikacji

#zip data
Add-Type -assembly "system.io.compression.filesystem"
[io.compression.zipfile]::CreateFromDirectory($temp_path_logs, $result_zip) 


#send data
function Send-Email{
    $username = "sqlink@o2.pl"
    $password = ConvertTo-SecureString '!YU0mkInVfv^' -AsPlainText -Force
    $credentials = New-Object System.Management.Automation.PSCredential($username, $password)
    Send-MailMessage -Body "Check attached .zip file" -Subject "Last $logged_hours hours of System and Application logs, from ${env:COMPUTERNAME}" -From "sqlink@o2.pl" -UseSsl -To $recipient -Attachment $result_zip -SmtpServer 'poczta.o2.pl' -Credential $credentials
}

Start-Sleep -s 2
Send-Email
Start-Sleep -s 2
Remove-Item $temp_path_logs -Recurse -ErrorAction Ignore
Remove-Item $temp_path_main -Recurse -ErrorAction Ignore