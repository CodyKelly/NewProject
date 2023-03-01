using System;
using Nez;
using Microsoft.Xna.Framework;

namespace NewProject
{
  class PlayerEntity : Entity
  {
    private Health _health;

    public override void OnAddedToScene()
    {
      base.OnAddedToScene();
      var map = ((BasicScene)Scene).Map;

      var downAtlas = Scene.Content.LoadTexture(Nez.Content.Textures.Character.Armorlancer.Armorlancerdownpng);
      var sideAtlas = Scene.Content.LoadTexture(Nez.Content.Textures.Character.Armorlancer.Armorlancersidepng);
      var upAtlas = Scene.Content.LoadTexture(Nez.Content.Textures.Character.Armorlancer.Armorlanceruppng);

      AddComponent(new AnimationController(ref sideAtlas, ref downAtlas, ref upAtlas, 5f));
      AddComponent(new PlayerController());
      AddComponent(new Health());

      Transform.SetPosition(map.TileToWorldPosition(map.HighestPoint));
    }

    public override void OnRemovedFromScene()
    {
      base.OnRemovedFromScene();
    }
  }
}