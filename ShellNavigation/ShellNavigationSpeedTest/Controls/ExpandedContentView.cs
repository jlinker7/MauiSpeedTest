using System.Runtime.CompilerServices;

namespace ShellNavigationSpeedTest.Controls
{
    public interface IRendererResolver
    {
        object GetRenderer(VisualElement element);

        bool HasRenderer(VisualElement element);
    }

    public class ExpandedContentView : ContentView
    {
        protected override void OnParentSet()
        {
            base.OnParentSet();

            ParentOnAppearing(null, null);

            if(Parent == null)
            {
                DisposeBindingContext();
            }
        }

        protected virtual void OnAppearing() { }

        protected virtual void OnDisappearing() { }

        #region Life Cycle Handlers

        private ContentPage ParentPage;
        private bool IsRegistered;

        private bool OnAppearingFired;

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if(propertyName.Equals("Renderer", StringComparison.OrdinalIgnoreCase))
            {
                IRendererResolver rr = DependencyService.Get<IRendererResolver>();
                if(rr.HasRenderer(this))
                {
                    Unregister();

                    Element parent = Parent;
                    while(parent?.Parent != null && !(parent is ContentPage))
                    {
                        parent = parent.Parent;
                    }

                    if(parent is ContentPage page)
                    {
                        ParentPage = page;
                        Register();
                    }
                }
            }
        }

        private void Register()
        {
            if(ParentPage != null && !IsRegistered)
            {
                //Bind to Parent Events
                ParentPage.Appearing += ParentOnAppearing;
                ParentPage.Disappearing += ParentOnDisappearing;

                IsRegistered = true;
            }
        }

        private void Unregister()
        {
            if(ParentPage != null && IsRegistered)
            {
                //UnBind from Parent Events
                ParentPage.Appearing -= ParentOnAppearing;
                ParentPage.Disappearing -= ParentOnDisappearing;

                IsRegistered = false;
                ParentPage = null;
            }
        }

        private void ParentOnAppearing(object sender, EventArgs e)
        {
            //Due to the order of when events are fired.  We fire OnAppearing from the Controls (inheriting from ExpandedContentView) in the OnParentSet as it may fire after 
            //The parent's OnAppearing has already fired and thus misses the chance to run it.  But, if the app is backgrounded (which fires OnDisappearing and will set OnAppearingFired
            //to false) and re-foregrounded and the parent's OnAppearing fires again, then we will refire OnAppearing
            if(!OnAppearingFired)
            {
                OnAppearingFired = true;
                OnAppearing();
            }
        }

        private void ParentOnDisappearing(object sender, EventArgs e)
        {
            OnAppearingFired = false;
            OnDisappearing();
        }

        protected void DisposeBindingContext()
        {
            if(BindingContext is IDisposable disposableBindingContext)
            {
                disposableBindingContext.Dispose();
                BindingContext = null;
            }
        }

        ~ExpandedContentView()
        {
            DisposeBindingContext();
        }

        #endregion
    }
}
