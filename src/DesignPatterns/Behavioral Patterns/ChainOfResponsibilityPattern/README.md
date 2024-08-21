# Chain of Responsibility Pattern

- Handler
Defines an interface for handling requests and, in this case, implements a successor link.

- ConcreteHandler1/2/3
These classes handle the requests that they are responsible for or forwards the request to its successor.

- Client
This initiates the request to a ConcreteHandler object on the chain

- Uses
This pattern is used to avoid coupling the sender of a request to its receiver.  It does this by giving multiple objects a chance to handle the request.
