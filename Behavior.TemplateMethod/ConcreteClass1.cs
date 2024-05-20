namespace Behavior.TemplateMethod
{
    /// <summary>
    /// Concrete implementation of AbstractClass, providing specific implementations for Step1 and Step3.
    /// </summary>
    public class ConcreteClass1 : AbstractClass
    {
        /// <inheritdoc/>
        protected override void Step1()
        {
            Console.WriteLine("ConcreteClass1: Implementing Step1");
        }

        /// <inheritdoc/>
        protected override void Step3()
        {
            Console.WriteLine("ConcreteClass1: Implementing Step3");
        }
    }
}
