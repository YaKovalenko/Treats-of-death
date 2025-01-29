using UnityEngine;

namespace Core.Services.Input
{
    public interface IInputService
    {
        Vector2 Axis { get; }
        bool IsAttackButton();
    }
}