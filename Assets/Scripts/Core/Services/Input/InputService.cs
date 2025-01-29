using UnityEngine;

namespace Core.Services.Input
{
    public class InputService : IInputService
    {
        private const string Horizontal = "Horizontal";
        private const string Button = "Fire";
        private const string Vertical = "Vertical";
        
        public Vector2 Axis => 
            new(SimpleInput.GetAxis(Horizontal), SimpleInput.GetAxis(Vertical));

        public bool IsAttackButton()
        {
            return SimpleInput.GetButtonUp(Button);
        }
    }
}