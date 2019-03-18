# XabalUniversalPlatform
An ASP.NET development platform secure by default

This package provides you with a complete development platform which contains:

- The latest version of application (intended as the latest application version tested without vulnerabilities with the latest version of the OWASP Zed Attack Proxy).
- The latest version of Bootstrap (provided by CDN, for updated versions of jQuery and Popper).
- The latest version of XAMPP (this repository provides the entire package, with DBs alredy setted, if you want to start from this build to code your application).

The release process is:
1. Setup application and dependencies
2. Setup XAMPP
3. Test application
4. Attack the application with ZAP with all marketplace packages setted up.
5. If attacks with ZAP and manual attacks don't affect the application, the entire package (Visual Studio Folder + XAMPP) is released to this repository.

How to use this application:
1. Clone repo with git or download zip.
2. Open local repo or extract files.
3. Go to the "WebSite1" folder, under "Projects" and open the solution with Visual Studio.

The application is built in .NET 4.0 (Visual Studio 2010), in the near future i will migrate this app in more Visual Studio and .NET versions (.NET Core too)
This application uses a very basic authentication system, made by me, and don't use Identity or features of .NET and don't use Xabal features like SHA512 hashing for passwords, to provide you a basic example and a starting point for your work.

For use the DB, you have to setup the ODBC MySQL Connector.

I hope you can find this solution useful!
I will release more docs in the future!

Stay tuned :)
