FROM microsoft/aspnetcore:latest
WORKDIR /app
COPY ./output .
ENV IS_CONTAINER true

EXPOSE 80
ENTRYPOINT ["dotnet", "DockerDemo.Api.dll"]