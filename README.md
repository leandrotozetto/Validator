# Validator
> It's an old library that I wrote to facilitate validations of entities and arguments.

## Usage example (Entity Validation)

    var validator = Validator<Entity>.New();
    var entity = Entity.New();

    validator.RuleFor(x => x.Quantity, nameof(Entity.Quantity)).GreaterThanOrEqual(10);

    var result = validator.Validate(entity);

    if(result.IsValid)
    {
      //code
    }

## Usage example (Argument Validation)
    /// <summary>
    /// Changes the value.
    /// </summary>
    /// <param name="name">New value.</param>
    public void ChangeName(string name)
    {
        Ensure.That(name, nameof(name)).IsNullOrWhiteSpace();

        //code
    }
