module ACoreDefs

  type 'a Maybe = 
      | Nothing of 'a
      | Just of 'a
      
      member self.Map f =
        match self with
        | Nothing x -> Nothing(x)
        | Just x -> Just(f x)
      
      member self.Fold (f,g) =
        match self with
        | Nothing x -> f x
        | Just x -> g x
      
      override self.ToString() =
        match self with
        | Nothing x -> $"Nothing({x})"
        | Just x -> $"Just({x})"


  let fromNullable x = if isNull(x) then Nothing(null) else Just(x)
  let id x = x