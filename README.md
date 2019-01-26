# PureDI (C#)

This library help you Dependency Injection pattern using Pure DI.  
PureDI was proposed by [Mark Seemann](http://blog.ploeh.dk/2014/06/10/pure-di/).  
[Jeon Suyeol](https://github.com/devxoul/Pure) made a great library with Swift.
  
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
public void Inject(IDepedencyType dependency, IPayloadType payload) {

}
```

Dependency injection is done by Composition Root. This idea is very powerful.

```c#
public class CompositionRoot {
    private CompositionRoot(Dependency dependency, Payload payload) {
        this.dependency = dependency;
        this.payload = payload;
    }

    public static CompositionRoot Resolve() {
        var dependency = new Dependency();
        var payload = new Payload();
        return new CompositionRoot(dependency: dependency, payload: payload);
    }
}
```

## Usage


