### **1. Abstraction**  
**Definition**: Abstraction simplifies complex systems by hiding unnecessary details and exposing only essential features. It focuses on "what" an object does rather than "how" it does it.  

**Example in Project**:  
In the **Exercise Tracking Program**, the base `Activity` class abstracts common behaviors (e.g., `GetSummary()`, `CalculateSpeed()`) without implementing activity-specific logic. Derived classes (e.g., `Running`, `Swimming`) handle the details.  

**Flexibility**:  
- Future activities (e.g., "Hiking") can be added by extending `Activity` without modifying existing code.  
- Changes to calculations (e.g., adjusting pace formulas) are localized to relevant subclasses.  

---

### **2. Encapsulation**  
**Definition**: Encapsulation bundles data (fields) and methods that operate on that data into a single unit (class), while restricting direct access to internal state via `private`/`protected` modifiers.  

**Example in Project**:  
The `Swimming` class encapsulates the `_laps` field as private and provides a public `GetDistance()` method to convert laps to miles/km. External code can’t modify `_laps` directly.  

**Flexibility**:  
- Internal representations can change (e.g., switching from laps to meters) without breaking other code.  
- Validation logic (e.g., ensuring `_laps > 0`) can be added to the setter later.  

---

### **3. Inheritance**  
**Definition**: Inheritance allows a class (child) to inherit fields/methods from another class (parent), promoting code reuse and hierarchical organization.  

**Example in Project**:  
`Running`, `Cycling`, and `Swimming` inherit shared properties (`_date`, `_minutes`) and methods (`GetSummary()`) from the `Activity` base class.  

**Flexibility**:  
- Common functionality (e.g., date formatting) is defined once in `Activity`.  
- New shared features (e.g., adding a `CaloriesBurned` property) can be added to the base class and inherited universally.  

---

### **4. Polymorphism**  
**Definition**: Polymorphism lets objects of different classes be treated as objects of a common superclass, with methods behaving differently based on the actual object type.  

**Example in Project**:  
The `GetDistance()` method is **overridden** in each subclass:  
- `Running` returns stored distance.  
- `Swimming` calculates distance from laps.  
- A `List<Activity>` can call `GetDistance()` uniformly, and the correct version executes.  

**Flexibility**:  
- New activity types can integrate seamlessly (e.g., `Rowing` with its own `GetDistance()` logic).  
- The `GetSummary()` method in `Activity` uses polymorphic calls to fetch subclass-specific data.  

---

### **How All Principles Enable Change**  
1. **Abstraction**: New features require minimal changes to high-level code (e.g., adding `Hiking` doesn’t affect `Main`).  
2. **Encapsulation**: Internal modifications (e.g., changing units from miles to km) don’t propagate to other classes.  
3. **Inheritance**: Shared logic updates (e.g., modifying `GetSummary()`) apply across all subclasses.  
4. **Polymorphism**: Existing code (e.g., loops iterating over `List<Activity>`) works with future subclasses without modification.  
