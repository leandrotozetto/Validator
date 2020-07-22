# Validator
> It's an old library that I wrote to facilitate validations of entities.

## Usage example

    var validator = Validator<Entity>.New();
    var entity = Entity.New();

    validator.RuleFor(x => x.Quantity, nameof(Entity.Quantity)).GreaterThanOrEqual(10);

    var result = validator.Validate(entity);

    if(result.IsValid)
    {
      //code
    }
