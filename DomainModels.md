#Domain Models:

1.
As a member of the public,
So I can order a bagel before work,
I'd like to add a specific type of bagel to my basket.

| Classes         | Methods              | Scenario                                           | Outputs                              |
|-----------------|----------------------|----------------------------------------------------|--------------------------------------|
| `Basket`        | `Add(string name)`   | Add a bagel to the basket based on the given name  | Add a bagel a List<string> of bagels |


2.
As a member of the public,
So I can change my order,
I'd like to remove a bagel from my basket.

| Classes         | Methods       | Scenario                                   | Outputs    |
|-----------------|---------------|--------------------------------------------|------------|
| `Basket`        | `Remove()`    | If basket is empty                         | false      |
|                 |               | If the basket has bagel/bagels, remove one | true       |

3.
As a member of the public,
So that I can not overfill my small bagel basket
I'd like to know when my basket is full when I try adding an item beyond my basket capacity.

| Classes         | Methods                 | Scenario                                                      | Outputs                       |
|-----------------|-------------------------|---------------------------------------------------------------|-------------------------------|
| `Basket`        | `IsFull()`              | If the basket is not yet full                                 | false                         |
|                 |                         | If the basket is full and cannot handle more bagels           | true                          |
|                 | `Add(string name)`      | Adding a bagel now checks if basket is full before proceeding | Only add if basket isn't full |

4.
As a Bob's Bagels manager,
So that I can expand my business,
I’d like to change the capacity of baskets.

| Classes         | Methods                 | Scenario                                                        | Outputs                       |
|-----------------|-------------------------|-----------------------------------------------------------------|-------------------------------|
| `Basket`        | `SetCapacity(int size)` | If the basket cannot be decreased due to having too many bagels | false                         |
|                 |                         | If the basket can be decreased/increased                        | true                          |

5.
As a member of the public
So that I can maintain my sanity
I'd like to know if I try to remove an item that doesn't exist in my basket.

| Classes         | Methods                 | Scenario                                       | Outputs    |
|-----------------|-------------------------|------------------------------------------------|------------|
| `Basket`        | `Remove(string name)`   | If that bagel doesn't exist in the basket      | false      |
|                 |                         | If that bagel exists in the basket, remove it  | true       |