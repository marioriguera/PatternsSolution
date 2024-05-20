namespace Behavior.TemplateMethod
{
    /// <summary>
    /// Concrete implementation of AbstractClass, providing specific implementations for all template steps.
    /// </summary>
    public class ConcreteClass2 : AbstractClass
    {
        /// <inheritdoc/>
        protected override void Step1()
        {
            Console.WriteLine("ConcreteClass2: Implementing Step1");
        }

        /// <inheritdoc/>
        protected override void Step2()
        {
            Console.WriteLine("ConcreteClass2: Implementing Step2");
        }

        /// <inheritdoc/>
        protected override void Step3()
        {
            Console.WriteLine("ConcreteClass2: Implementing Step3");
        }
    }
}
