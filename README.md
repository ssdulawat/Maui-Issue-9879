# Maui-Issue-9879

This repository is an example for the issue https://github.com/dotnet/maui/issues/9879

## Run locally in Visual Studio (no issue)

Clone the project and open `TestIssue9879/TestIssue9879.sln` in Visual Studio. Check, that the project `MauiApplication` is set as startup project and hit run on `Windows Machine`. The app should build and open up:

![image](https://user-images.githubusercontent.com/37712964/188624641-180afd55-9457-4e28-ae8e-2f469cd4b30e.png)

### Common issue

If the following appears:

![image](https://user-images.githubusercontent.com/37712964/188624732-73fdf325-7740-48ea-985a-e083a2cecc77.png)

Open the configuration manager:

![image](https://user-images.githubusercontent.com/37712964/188624823-e8b682a3-51c7-425c-bccd-4712ae632a5c.png)
 
 And uncheck the deployment for `MauiClassLibrary`:
 
 ![image](https://user-images.githubusercontent.com/37712964/188624889-a48465c7-39cd-45a1-8d94-56d114063847.png)

### Information for reproduction

This was tested on `Visual Studio Community 2022 Preview` in version `17.4.0 Preview 1.0` on a Windows 10 laptop.
