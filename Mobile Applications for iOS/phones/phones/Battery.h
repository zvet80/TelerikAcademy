//
//  Battery.h
//  phones
//
//  Created by z on 1/28/16.
//  Copyright © 2016 z. All rights reserved.
//

#import <Foundation/Foundation.h>

typedef NS_ENUM(NSUInteger,BatteryType){
    LiIon,
    NiMH,
    NiCd
};
#define BatteryTypeStringArray @"LiIon",@"NiMH",@"NiCd",nil

@interface Battery : NSObject

@property (strong,nonatomic) NSString* model;

@property int hoursIdle;

@property int hoursTalk;

@property BatteryType* type;

-(instancetype) initWithModel: (NSString*) model
                    hoursIdle: (int) hoursIdle
                    hoursTalk: (int) hoursTalk
               andBatteryType:(BatteryType*) batteryType;

+(Battery*)batteryWithModel:(NSString *)model hoursIdle:(int)hoursIdle hoursTalk:(int)hoursTalk andBatteryType:(BatteryType*)batteryType;

+(NSString*)batteryTypeToString:(BatteryType)enumVal;

@end
