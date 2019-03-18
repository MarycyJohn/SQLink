#|------------------------|
#|Author: Maurycy Graclik |
#|m.graclik@gmail.com     |
#|Date: 17/03/19          |
#|------------------------|

$temp_path_main = "C:\temp_SQLink" #temp main path
$temp_path_logs = "C:\temp_SQLink\temp_logs" #temp log path
$result_zip="C:\temp_SQLink\${env:COMPUTERNAME}_logs.zip" #destiunation zip
$localisation="C:\temp_SQLink\temp_logs\${env:COMPUTERNAME}_logs_from_${print_date}_in_behalf_of_user_$($env:UserName).txt" #extracted files
$logged_hours = 3 #number of hours to collect
$now=get-date
$print_date=get-date -f hh_mm_ss-dd_MM_yy
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
Remove-Item $temp_path_logs -Recurse -ErrorAction Ignore

#send data
function Send-Email{
    $username = "sqlink@o2.pl"
    $password = ConvertTo-SecureString '!YU0mkInVfv^' -AsPlainText -Force
    $credentials = New-Object System.Management.Automation.PSCredential($username, $password)
    #Send-MailMessage -Body "Check attachment" -Subject "Logs" -From "sqlink@o2.pl" -UseSsl -To "m.graclik@gmail.com" -Attachment "C:\Users\Maurycy\Desktop\testps\asd.txt" -SmtpServer 'poczta.o2.pl' -Credential $credentials
    Send-MailMessage -Body "Check attached .zip file" -Subject "Last $logged_hours hours of logs from ${env:COMPUTERNAME}" -From "sqlink@o2.pl" -UseSsl -To "m.graclik@gmail.com" -Attachment $result_zip -SmtpServer 'poczta.o2.pl' -Credential $credentials
}

Send-Email
Start-Sleep -s 1
Remove-Item $temp_path_main -Recurse -ErrorAction Ignore