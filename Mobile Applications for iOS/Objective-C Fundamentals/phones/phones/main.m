//
//  main.m
//  phones
//
//  Created by z on 1/26/16.
//  Copyright © 2016 z. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "AppDelegate.h"
#import "GSM.h"
#import "Battery.h"

int main(int argc, char * argv[]) {
        @autoreleasepool {        
            
        GSM* newGsm = [GSM gsmWithModel:@"new" andManufacturer:@"Nokia"];
        
        NSLog(@"%@", newGsm.model);
        //NSLog(@"%@",[Battery batteryTypeToString:(LiIon)]);
        
        return UIApplicationMain(argc, argv, nil, NSStringFromClass([AppDelegate class]));
    }
}
