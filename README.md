# yelp-sharp

A simple Yelp client for C#.

Built as a PCL with support for the following platforms:

* .NET 4.5+
* Silverlight 5+
* Windows 8+
* Windows Phone 8.1+
* Xamarin.Android+
* Xamarin.iOS+

Based on [YelpSharp](https://github.com/JustinBeckwith/YelpSharp) by [Justin Beckwith](https://github.com/JustinBeckwith) with the following changes:

* Supports the majority of PCL platforms (not just .NET and Windows Phone).
* Added async.
* Made non-data classes immutable.
* Removed superfluous abstract classes in favour of interfaces.
* Prefixed classes with Yelp.
* General tidying up.

## Build Status

[![Build status](https://ci.appveyor.com/api/projects/status/40327aukjpg6y3gv/branch/master?svg=true)](https://ci.appveyor.com/project/JoeBrock73129/yelp-sharp/branch/master)
