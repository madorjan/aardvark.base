﻿namespace Aardvark.Base.Incremental.Tests

open System
open System.Collections
open System.Collections.Generic
open Aardvark.Base.Incremental
open NUnit.Framework
open FsUnit
open System.Diagnostics
open Aardvark.Base

module SimplePerfTests =

    [<Test>]
    let ``[Mod Performance] deep bind``() =
        
        let mods = List.init 500 (fun i -> Mod.init i)

        let rec flatten l =
            match l with
                | [] -> Mod.constant 0
                | x::xs ->
                    adaptive {
                        let! v = x
                        let! rest = flatten xs
                        return v + rest
                    }

        let sum = flatten mods

        // warmup
        sum |> Mod.force |> ignore


        let sum = flatten mods
        let sw = Stopwatch()
        sw.Start()
        sum |> Mod.force |> ignore
        sw.Stop()

        Console.WriteLine("elapsed: {0}ms", sw.Elapsed.TotalMilliseconds)


    [<Test>]
    let ``[Mod Performance] deep bind with fixed levels``() =
        
        let mods = List.init 500 (fun i -> Mod.init i)

        let rec flatten level l =
            match l with
                | [] -> Mod.constant 0
                | x::xs ->
                    let res = 
                        adaptive {
                            let! v = x
                            let! rest = flatten (level - 3) xs
                            return v + rest
                        }
                    res.Level <- level
                    res

        let sum = flatten 2000 mods

        // warmup
        sum |> Mod.force |> ignore


        let sum = flatten 2000 mods
        let sw = Stopwatch()
        sw.Start()
        sum |> Mod.force |> ignore
        sw.Stop()

        Console.WriteLine("elapsed: {0}ms", sw.Elapsed.TotalMilliseconds)


    [<Test>]
    let ``[Mod Performance] flat sum``() =
        
        let mods = List.init 500 (fun i -> Mod.init i)

        let sum = 
            mods |> List.map (fun m -> m :> IAdaptiveObject) |> Mod.mapCustom (fun self ->
                mods |> List.map (fun s -> s.GetValue self) |> List.sum
            )
        // warmup
        sum |> Mod.force |> ignore


        let sum = 
            mods |> List.map (fun m -> m :> IAdaptiveObject) |> Mod.mapCustom (fun self ->
                mods |> List.map (fun s -> s.GetValue self) |> List.sum
            )

        let sw = Stopwatch()
        sw.Start()
        sum |> Mod.force |> ignore
        sw.Stop()

        Console.WriteLine("elapsed: {0}ms", sw.Elapsed.TotalMilliseconds)

    [<Test>]
    let ``[ASet] value dependent nop change``() =
        let vt = Mod.init V3d.Zero
        let iter = 100

        let instances =
            aset {
                for x in 0..20 do
                    for y in 0..20 do
                        for z in 0..20 do
                            yield fun (i : int) -> Array.zeroCreate (1 <<< i)
            }

        let getLevel (m : IMod<V3d>) (f : int -> int[]) =
            let mutable current = None
            adaptive {
                let! m = m

                let level = 
                    match V3d.Distance(m, m) with   
                        | v when v < 100.0 -> 0
                        | _ -> 0

                match current with
                    | Some (l,v) when l = level ->
                        return v
                    | _ ->
                        let v = f level
                        current <- Some (level, v)
                        return v
            }

        let final =
            instances |> ASet.mapM (getLevel vt)

        let r = final.GetReader()

        r.GetDelta() |> ignore

        let sw = Stopwatch()
        sw.Start()
        for i in 1..iter do
            transact (fun () -> Mod.change vt (vt.Value + V3d.III))
            r.GetDelta() |> ignore
        sw.Stop()


        sprintf "took: %.3fms" (sw.Elapsed.TotalMilliseconds / float iter) |> Console.WriteLine






