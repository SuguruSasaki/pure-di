# PureDI (C#)

This library help you Dependency Injection pattern using Pure DI.  
PureDI was proposed by [Mark Seemann](http://blog.ploeh.dk/2014/06/10/pure-di/).  
[Jeon Suyeol](https://github.com/devxoul/Pure) made a very good library with Swift.
  
This library is a port of Swift's Pure to C #.

## About Pure DI

PureDI does not use the DI container. Usually Pure DI will use constructor injection.  


```c#
// Constructor injection
public SampleClass(Dependency dependency, Palyad payload) {

}
```

Of course this is also good, but in C # we use the Inject method.

```c#
public void Inject(TargetDepedency dependency, TargetPayload payload) {

}
```


## Usage


