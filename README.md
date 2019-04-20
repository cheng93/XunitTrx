```
docker pull mcr.microsoft.com/dotnet/core/sdk:2.2
docker run -v <REPOSITORY_LOCATION>:/home/XunitTrx -it mcr.microsoft.com/dotnet/core/sdk:2.2 /bin/bash 
```

```
cd home/XunitTrx
dotnet test  -v d --logger trx -r ../TestResults --diag:../TestResults/log.txt   
```