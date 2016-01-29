//
//  GSMList.h
//  phones
//
//  Created by z on 1/29/16.
//  Copyright © 2016 z. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface GSMList : NSObject
extern NSMutableArray *phones;

+(void)seedPhones;
@end
