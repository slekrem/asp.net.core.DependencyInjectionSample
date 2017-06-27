namespace DependencyInjectionSample.Services
{
    using System;
    using Interfaces;

    public class Operation : IOperationScoped, IOperationSingleton, IOperationSingletonInstance, IOperationTransient
    {
        private readonly Guid _operationId;

        public Guid OperationId => _operationId;

        public Operation() : this(Guid.NewGuid()) { }

        public Operation(Guid operationId)
        {
            _operationId = operationId;
        }
    }
}
