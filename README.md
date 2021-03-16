This is a diff/merge app for C# model classes to SQL Server. You can also merge from database to database. Here's my main [product page](https://aosoftware.net/modelsync/).

[![download](https://img.shields.io/badge/Download-Installer-blue.svg)](https://aosoftware.blob.core.windows.net/install/ModelSyncSetup.exe)

Icon looks like this:

![img](https://adamosoftware.blob.core.windows.net/images/R6CAG0JHJQ.png)

The app has a 30-day fully functional free trial. After that, a perpetual license is $50 USD.

[![paypal](https://www.paypalobjects.com/webstatic/mktg/logo/pp_cc_mark_74x46.jpg)](https://paypal.me/adamosoftware?locale.x=en_US)

You're welcome to clone and examine this repo of course. If you use Model Sync for real, I do ask you to please buy a license.

## About the Repo
- The WinForms UI is the [App](https://github.com/adamfoneil/ModelSync.WinForms/tree/master/ModelSync.App) project, this repo. Note there is a [post build event](https://github.com/adamfoneil/ModelSync.WinForms/blob/master/ModelSync.App/ModelSync.App.csproj#L194) that won't work on your machine that you will need to remove.
- You will also need to clone the [ModelSync library](https://github.com/adamfoneil/ModelSync) project because the App references the `ModelSync` library as a project within the solution. This allowed me to get the best debug experience.