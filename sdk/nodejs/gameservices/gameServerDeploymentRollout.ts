// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * This represents the rollout state. This is part of the game server
 * deployment.
 *
 * To get more information about GameServerDeploymentRollout, see:
 *
 * * [API documentation](https://cloud.google.com/game-servers/docs/reference/rest/v1beta/GameServerDeploymentRollout)
 * * How-to Guides
 *     * [Official Documentation](https://cloud.google.com/game-servers/docs)
 *
 * ## Example Usage
 */
export class GameServerDeploymentRollout extends pulumi.CustomResource {
    /**
     * Get an existing GameServerDeploymentRollout resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: GameServerDeploymentRolloutState, opts?: pulumi.CustomResourceOptions): GameServerDeploymentRollout {
        return new GameServerDeploymentRollout(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'gcp:gameservices/gameServerDeploymentRollout:GameServerDeploymentRollout';

    /**
     * Returns true if the given object is an instance of GameServerDeploymentRollout.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is GameServerDeploymentRollout {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === GameServerDeploymentRollout.__pulumiType;
    }

    /**
     * This field points to the game server config that is
     * applied by default to all realms and clusters. For example,
     * `projects/my-project/locations/global/gameServerDeployments/my-game/configs/my-config`.
     */
    public readonly defaultGameServerConfig!: pulumi.Output<string>;
    /**
     * The deployment to rollout the new config to. Only 1 rollout must be associated with each deployment.
     */
    public readonly deploymentId!: pulumi.Output<string>;
    /**
     * The gameServerConfigOverrides contains the per game server config
     * overrides. The overrides are processed in the order they are listed. As
     * soon as a match is found for a cluster, the rest of the list is not
     * processed.
     * Structure is documented below.
     */
    public readonly gameServerConfigOverrides!: pulumi.Output<outputs.gameservices.GameServerDeploymentRolloutGameServerConfigOverride[] | undefined>;
    /**
     * The resource id of the game server deployment eg:
     * 'projects/my-project/locations/global/gameServerDeployments/my-deployment/rollout'.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The ID of the project in which the resource belongs.
     * If it is not provided, the provider project is used.
     */
    public readonly project!: pulumi.Output<string>;

    /**
     * Create a GameServerDeploymentRollout resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: GameServerDeploymentRolloutArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: GameServerDeploymentRolloutArgs | GameServerDeploymentRolloutState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as GameServerDeploymentRolloutState | undefined;
            inputs["defaultGameServerConfig"] = state ? state.defaultGameServerConfig : undefined;
            inputs["deploymentId"] = state ? state.deploymentId : undefined;
            inputs["gameServerConfigOverrides"] = state ? state.gameServerConfigOverrides : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["project"] = state ? state.project : undefined;
        } else {
            const args = argsOrState as GameServerDeploymentRolloutArgs | undefined;
            if (!args || args.defaultGameServerConfig === undefined) {
                throw new Error("Missing required property 'defaultGameServerConfig'");
            }
            if (!args || args.deploymentId === undefined) {
                throw new Error("Missing required property 'deploymentId'");
            }
            inputs["defaultGameServerConfig"] = args ? args.defaultGameServerConfig : undefined;
            inputs["deploymentId"] = args ? args.deploymentId : undefined;
            inputs["gameServerConfigOverrides"] = args ? args.gameServerConfigOverrides : undefined;
            inputs["project"] = args ? args.project : undefined;
            inputs["name"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(GameServerDeploymentRollout.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering GameServerDeploymentRollout resources.
 */
export interface GameServerDeploymentRolloutState {
    /**
     * This field points to the game server config that is
     * applied by default to all realms and clusters. For example,
     * `projects/my-project/locations/global/gameServerDeployments/my-game/configs/my-config`.
     */
    readonly defaultGameServerConfig?: pulumi.Input<string>;
    /**
     * The deployment to rollout the new config to. Only 1 rollout must be associated with each deployment.
     */
    readonly deploymentId?: pulumi.Input<string>;
    /**
     * The gameServerConfigOverrides contains the per game server config
     * overrides. The overrides are processed in the order they are listed. As
     * soon as a match is found for a cluster, the rest of the list is not
     * processed.
     * Structure is documented below.
     */
    readonly gameServerConfigOverrides?: pulumi.Input<pulumi.Input<inputs.gameservices.GameServerDeploymentRolloutGameServerConfigOverride>[]>;
    /**
     * The resource id of the game server deployment eg:
     * 'projects/my-project/locations/global/gameServerDeployments/my-deployment/rollout'.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The ID of the project in which the resource belongs.
     * If it is not provided, the provider project is used.
     */
    readonly project?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a GameServerDeploymentRollout resource.
 */
export interface GameServerDeploymentRolloutArgs {
    /**
     * This field points to the game server config that is
     * applied by default to all realms and clusters. For example,
     * `projects/my-project/locations/global/gameServerDeployments/my-game/configs/my-config`.
     */
    readonly defaultGameServerConfig: pulumi.Input<string>;
    /**
     * The deployment to rollout the new config to. Only 1 rollout must be associated with each deployment.
     */
    readonly deploymentId: pulumi.Input<string>;
    /**
     * The gameServerConfigOverrides contains the per game server config
     * overrides. The overrides are processed in the order they are listed. As
     * soon as a match is found for a cluster, the rest of the list is not
     * processed.
     * Structure is documented below.
     */
    readonly gameServerConfigOverrides?: pulumi.Input<pulumi.Input<inputs.gameservices.GameServerDeploymentRolloutGameServerConfigOverride>[]>;
    /**
     * The ID of the project in which the resource belongs.
     * If it is not provided, the provider project is used.
     */
    readonly project?: pulumi.Input<string>;
}
