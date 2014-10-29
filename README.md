LRUCache
========

What is it?
-----------

A lightweight thread-safe LRU cache for .NET

How can I get it?
-----------------

LRUCache is available as a NuGet package: https://www.nuget.org/packages/LRUCache

```
PM> Install-Package LRUCache
```

Why was it made?
----------------

I wanted a straightforward, lightweight thread-safe LRU cache, and I couldn't find a good one to just drop in anywhere on NuGet, so I made one.


Example Usage
-------------

``` csharp
var cache = new LRUCache<int, string>(capacity: 1000);
var key = 1;
var value = "Hello";
cache.Add(key, value);

string valueInCache;
cache.TryGetValue(key, out valueInCache);
// valueInCache is now "Hello"
```
