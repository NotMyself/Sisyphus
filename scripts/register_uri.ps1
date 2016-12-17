$user = "$([Environment]::UserDomainName)\$([Environment]::UserName)"
netsh http add urlacl http://+:8080/ user=$user