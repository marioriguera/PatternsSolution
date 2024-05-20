namespace Behavior.TemplateMethod
{
    /// <summary>
    /// Abstract class defining the template method pattern.
    /// </summary>
    public abstract class AbstractClass
    {
        /// <summary>
        /// Template method that defines the algorithm structure and order of execution.
        /// </summary>
        public void TemplateMethod()
        {
            Step1();
            Step2();
            Step3();
        }

        /// <summary>
        /// Abstract step that must be implemented by concrete subclasses.
        /// </summary>
        protected abstract void Step1();

        /// <summary>
        /// Concrete step with a default implementation that can be optionally overridden.
        /// </summary>
        protected virtual void Step2()
        {
            // Default implementation
            Console.WriteLine("AbstractClass: Default implementation of Step2");
        }

        /// <summary>
        /// Abstract step that must be implemented by concrete subclasses.
        /// </summary>
        protected abstract void Step3();
    }
}
