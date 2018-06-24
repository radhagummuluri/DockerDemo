FROM microsoft/aspnetcore:latest
WORKDIR /app
COPY ./output .
ENV IS_CONTAINER true

RUN apt-get update
RUN apt-get install -qq --force-yes fontconfig
COPY ./output/Fonts/Roboto-Bold.ttf /usr/share/fonts
# Rebuild the font cache.
RUN fc-cache -fv

EXPOSE 80
ENTRYPOINT ["dotnet", "DockerDemo.Web.dll"]